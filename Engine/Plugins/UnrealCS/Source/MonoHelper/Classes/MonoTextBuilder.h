// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt
#pragma once

class MONOHELPER_API FMonoTextBuilder
{
    bool onNewLine = true;
	//深度
	int depth;
	FString Report;

public:
	FMonoTextBuilder()
	{
		depth = 0;
	}
	//缩进
	void Indent()
	{
		++depth;
	}
	//缩出
	void Unindent()
	{
		--depth;
	}

	void Append(const FMonoTextBuilder& text)
	{
		FString NewSummaryText = text.ToText().Replace(TEXT("\r"), TEXT(""));

		TArray<FString> Lines;
		NewSummaryText.ParseIntoArray(Lines, TEXT("\n"), true);

		for (auto&& Line : Lines)
		{
			AppendLine(Line);
		}
	}

	void Append(const FString& text)
	{
        AppendIndent();
        Report += text;
	}

    void AppendIndent() {
        if (onNewLine) {
            for (int32 Index = 0; Index < depth; Index++) {
                Report += TEXT("\t");
            }
            onNewLine = false;
        }
	}

	void AppendLine()
	{
        AppendIndent();
        if (!Report.IsEmpty())
		{
			Report += LINE_TERMINATOR;
		}
        onNewLine = true;
    }

    void AppendLine(const FString& text)
	{
        AppendIndent();
        Report += text;
		AppendLine();
    }

    void AppendLine(const TCHAR* Line)
	{
		AppendLine(FString(Line));
	}

    void OpenBrace()
	{
		Append(TEXT("{"));
		Indent();
        AppendLine();
	}

	void CloseBrace()
	{
		AppendLine();
        Unindent();
        AppendLine(TEXT("}"));
	}

	const FString& ToText() const{ return Report; }

	void Clear()
	{
		Report.Empty();
		depth = 0;
	}

	FMonoTextBuilder& operator+=(const FString& text)
	{
		Append(text);
		return *this;
	}

	FMonoTextBuilder& operator+=(const FMonoTextBuilder& text)
	{
		Append(text);
		return *this;
	}

	int32 GetDepth() const { return depth; }
};