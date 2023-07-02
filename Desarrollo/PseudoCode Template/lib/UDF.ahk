﻿#Requires AutoHotkey v2.0
#Include <JXON>
#Include <class_persistentData>

; Functions
getInputData(prompt := "Enter your data", options := "", default := "", dataType := "string") {
	editedPrompt := prompt
	while 1
	{
		IB := InputBox(editedPrompt, , options, default)
		if IB.result = "cancel"
			exit
		if IB.Value = "A_Clipboard"
			{
				IB.Value := A_Clipboard
				editedPrompt:= "You've chosen to get from clipboard"
				default := IB.Value
				continue
			}
		switch dataType, 0 {
			case "path": goto Paths
			case "file":
Paths:
				if FileExist(IB.Value)
					break
				editedPrompt := Format(prompt "`r`nInvalid File Path!:`r`n    {}", IB.Value)
				default := IB.value
				continue
			default:
				editedPrompt := prompt
				if MsgBox(Format("Accept?`r`nYour input is:`r`n{}",IB.value)) != "Yes"
					continue
		}
		break
	}
	return IB.value
}

stringJoin(inputString, Amount) {
	temp := ""
	Loop Amount
		temp .= InputString
	return temp
}

QPC(Counter := "", Decimals := 2) {
	static freq
	If Counter = ""
	{
		DllCall("QueryPerformanceFrequency", "Int64*", &freq := 0)
			, DllCall("QueryPerformanceCounter", "Int64*", &Counter := 0)
		return Counter
	}
	DllCall("QueryPerformanceCounter", "Int64*", &CounterAfter := 0)
	return Round((CounterAfter - Counter) / Freq * 1000, Decimals)
}
SetListVars(Text, DoWaitMsg := 0, msgboxText := "Waiting.....") {
	ListVars
	WinWaitActive "ahk_class AutoHotkey"
	ControlSetText Text, "Edit1"
	if DoWaitMsg
		Msgbox msgboxText
}

DisplayMap(InputObject, LineNumber := "", Padding := 4) {
	Static Iteration := 0
	InputObject := getPropMap(InputObject)
	SetlistVars(StrReplace(JXON.Dump(InputObject, Padding), "`n", "`r`n"))
	msgbox "Displaying Map :" (Iteration += 1) " `r`n" LineNumber
}

getPropMap(Input, validProps := ["Value"], level := 1, cap := 10) {
	tempMap := Map()
	if Input is Map or Input is Array
	{
		For k, v in Input ; Gives priority to Map's data.
		{
			If (isObj := IsObject(v)) && (level < cap)
				v := getPropMap(v, validProps, level + 1)
			else if level >= cap && isObj
				v := Type(v)
			tempMap.Set(k, v)
		}
	}
	else
		for prop, v in Input.OwnProps()
		{
			If (isObj := IsObject(v)) && (level < cap)
				v := getPropMap(v, validProps, level + 1)
			else if (level >= cap && isObj)
				v := Type(v)
			if (validProps = "All")
				tempMap.Set(prop, v)
			Else
				for validName in validProps
					if (prop = validName)
					{
						if validProps.Length = 1
							tempMap := v
						else
							tempMap.Set(prop, v)
					}
		}
	return tempMap
}

Class UDF {
	Static ErrorFormat(errObject) =>
		Format("{1}: {2}.`n`nFile:`t{3}`nLine:`t{4}`nWhat:`t{5}`nStack:`n{6}"
			, type(errObject), errObject.Message, errObject.File, errObject.Line, errObject.What, errObject.Stack)

	Static getPropsList(inputObject, LineNumber := "", maxStrLen := 50) {
		Text := ""
		for prop, _ in inputObject.OwnProps()
		{
			(IsObject(_) ? Format(" : [{1:#x}] {2}", ObjPtr(_), Type(_)) : " : " SubStr(_, 1, 50))
			If IsObject(_)
			{
				switch ObjType := Type(_), 0 {
					case "Array":
						type_Size := Format("({})", _.Length)
					case "Map":
						type_Size := Format("({})", _.Count)
					default:
						type_Size := ""
				}
				Value := Format(" : [{1:#x}] {2}", ObjPtr(_), ObjType type_Size)
			}
			else
				Value := ((ValLen := strlen(_)) >= maxStrLen ? Format("{}...({})", SubStr(_, 1, StrOffset := maxStrLen - 10), ValLen - StrOffset) : _)
			Text .= Format("{} : {}`r`n", prop, Value)
		}
		return (LineNumber = "" ? "" : LineNumber "`r`n") Text
	}

	Class Map Extends Map {
		CaseSense := "Off"
		StartUp := A_Now
	}
	Static IniRead(Filename, Section := "", Key := "", Default := "", Auto := "") {
		; Auto is for what value to Write&Return in case the IniRead Target doesn't exists
		OutputVar := IniRead(Filename, Section, Key, Default)
		If (!(Auto = "") and OutputVar = Default)
		{
			this.IniWrite(Auto, Filename, Section, Key, True)
			return Auto
		}
		return OutputVar
	}
	Static IniWrite(Input, Filename, Section := "", Key := "", AutoCreate := False) {
		If (!(FileExist(Filename)) and AutoCreate)
			DirCreate RegExReplace(Filename, "[^\\]+$", "") ; This is in case you have something like "C:\Path\Path2\SomeFile.ini" -> "C:\Path\Path2\"
		IniWrite Input, Filename, Section, Key
		return A_LastError ;I honestly don't know what this does. So I'm leaving this just in case.
	}
}