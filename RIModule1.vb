Imports System.Data.SqlClient

Module RIModule1
    Public Conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\HRMngData.mdf;Integrated Security=True;User Instance=True")
    Public SqlStr, q1Var, q2Var As String
    Public sinChar As String
    Public colVar, rowVar, I, J, K, L1 As Long
    Public vTypeVar As Byte
    Public Con1 As Boolean
    Public cCodeVar As Long

    Enum CtrlType
        TextBox = 1
        ComboBox = 2
    End Enum
    Public Sub ClearTxtControls(ByRef frm As Object, ByRef ControlType As CtrlType, Optional ByRef Tagstr As Object = Nothing)
        Dim Contrl As Object
        For Each Contrl In frm.Controls
            If Not (IsNothing(Tagstr)) Then
                If Trim(UCase(Contrl.Tag)) = Trim(UCase(Tagstr)) Then
                    Contrl.Text = ""
                    Exit For
                End If
            Else
                Select Case ControlType
                    Case CtrlType.ComboBox
                        If TypeOf Contrl Is System.Windows.Forms.ComboBox Then Contrl.Text = ""
                    Case CtrlType.TextBox
                        If TypeOf Contrl Is System.Windows.Forms.TextBox Then Contrl.Text = ""
                End Select
            End If
        Next Contrl
        Contrl = Nothing
    End Sub


    Public Function CheckChar(ByRef CharString As Object) As String
        L1 = Len(CharString)
        CharString = UCase(Left(CharString, 1)) & Right(CharString, L1 - 1)
        For I = 1 To L1
            If Con1 = True Then CharString = Mid(CharString, 1, I - 1) & UCase(Mid(CharString, I, 1)) & Mid(CharString, I + 1, L1)
            SinChar = Mid(CharString, I, 1)
            If SinChar = " " Then
                Con1 = True
            Else
                Con1 = False
            End If
        Next I
        CheckChar = CharString
    End Function

    Public Function CheckNum(ByRef KeyVar As String) As String
        If Asc(KeyVar) = 8 Then
            CheckNum = KeyVar : Exit Function
        End If
        If Asc(KeyVar) < 46 Or Asc(KeyVar) > 57 Then
            CheckNum = Nothing
            MsgBox("Please Enter Numbers Only")
        Else
            CheckNum = KeyVar
        End If
        If Asc(KeyVar) = 47 Then CheckNum = Nothing

    End Function
    Public Function forCur(ByRef CurAmt As Object) As Object
        forCur = Format(CurAmt, "##,##,##0.00")
    End Function
    Public Function forDate(ByRef DateVar As Object) As Object
        forDate = Format(DateVar, "dd/MMM/yyyy")
    End Function
End Module
