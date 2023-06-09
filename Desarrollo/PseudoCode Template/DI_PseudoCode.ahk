﻿#Requires AutoHotkey v2.0


ImprimirMatriz(Matrix) {
    MiFilas := ""
    for fila, v in Matrix
    {
        valoresEnLaColumna := ""
        for columna, v in Matrix[fila]
        {
            valoresEnLaColumna := valoresEnLaColumna "`r`nCol_" columna ":`t" matrix[fila][columna]
        }
        MiFilas := MiFilas "fila_" fila "-), " valoresEnLaColumna
        insertarSaltoDeLinea(&MiFilas)
    }
    SetListVars(MiFilas)

    insertarSaltoDeLinea(&texto) {
        texto := texto "`r`n"
    }
    return MiFilas
}
ImprimirMatrizJSON(Matrix, returnString := false) {
    MiFilas := ""
    for fila_index, fila in Matrix
        MiFilas .= Format("  {}`r`n", JXON.Dump(fila))
    MiFilas := "[`r`n" MiFilas "]`r`n"
    if !returnString
        SetListVars(MiFilas)
    return MiFilas
}
class C_Columna extends Map {
    Default := ""
    __Item[ind] {
        set {
            if !super.has(ind)
            {
                super[ind] := value
                return
            }
            super[ind] := value
        }
        get {
            if !super.has(ind)
            {
                this[ind] := this.Default
                return super[ind]
            }
            return super[ind]
        }
    }
}
class Matriz_2D extends C_Fila {

}
class C_Fila extends Map {

    __Item[ind] {
        get {
            if !super.has(ind)
            {
                super[ind] := C_Columna()
                return super[ind]
            }
            return super[ind]
        }

    }
}

; __Leer(prompt := "Enter your data", options := "", default := "", dataType := "string", confirmPrompt := true) {
;     editedPrompt := prompt
;     while 1
;     {
;         IB := InputBox(editedPrompt, , options, default)
;         if IB.result = "cancel"
;             exit
;         if IB.Value = "A_Clipboard"
;         {
;             if SetListVars(IB.Value := A_Clipboard, 1, "You've chosen to get from clipboard. Do you want to proceed?", 0x4) != "yes"
;                 continue
;             default := "A_Clipboard"
;             return A_Clipboard
;         }
;         switch dataType, 0 {
;             case "path": goto Paths
;             case "file":
; Paths:
;                 if FileExist(IB.Value)
;                     break
;                 editedPrompt := Format(prompt "`r`nInvalid File Path!:`r`n    {}", IB.Value)
;                 default := IB.value
;                 continue
;             default:
;                 editedPrompt := prompt
;                 if confirmPrompt && SetListVars(Format("Accept?`r`nYour input is:`r`n{}", IB.value), true) != "Yes"
;                     continue
;         }
;         break
;     }
;     return IB.value
; }

Escribir(params*) {
    console.print(params*)
    console.query := console.lastLine
}
Imprimir(params*) => console.print(params*)

class console {
    static storedText := ""
    static query := ""
    static lastLine := ""
    static print(params*) {
        static console := "ahk_class AutoHotkey"
        text := ""
        for ind, v in params
            text .= v
        this.lastLine := text "`r`n"
        this.storedText .= text "`r`n"
        if !WinExist(console) {
            SetListVars(this.storedText)
            return
        }
        ControlSetText(this.storedText, "Edit1", console)
    }
    static Leer(&variable?) {
        if this.query != ""
            query := this.query, this.query := "", this.lastLine := ""
        else
            query := "Ingrese su Dato de Lectura"
        variable := InputBox(query, "Pseudo Codigo Ing.Sistemas").Value
        this.storedText := Trim(this.storedText, "`r`n") variable
        this.print("")
        return variable
    }
}

Class ArrayOfSize extends Array {
    __New(size, Values*) {
        if Values.Length
        {
            if Values is Array
                this.__fillWith(size, values*)
            else
                this.__fillWith(size, values)
            return
        }
        loop size
            this.Push("")
    }
    __fillWith(size, Values*) {
        if !(values.Length = 1 or values.Length = size)
            throw ValueError("Default Size doesn't match your Array's size!")
        if values.Length = 1 {
            loop size
                this.Push(Values[1])
        }
        else
            loop size
                this.Push(Values[A_Index])
    }
}
Class ArrayWithPrint extends ArrayOfSize {
    __item[index] {
        get => super[index]
        set {
            if IsNumber(value)
                super[index] := Number(value)
            else
                super[index] := value
            console.print(A_Tab JXON.dump(this))
        }
    }
}