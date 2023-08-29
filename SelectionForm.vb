Imports System.Data.SqlClient
Public Class SelectionForm

    Private Sub SelectionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd3 As New SqlCommand("select distinct JobCode from rMatchListTab order by JobCode", Conn)
        Dim D3 As SqlDataReader = Cmd3.ExecuteReader()
        While D3.Read
            ComboBox1.Items.Add(D3(0).ToString)
        End While
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim XPos, YPos As Long
        YPos = 50
        Dim MyFont As New Font("Arial", 18)
        XPos = 10
        e.Graphics.DrawString("HR Management", MyFont, Brushes.Black, XPos, YPos)
        YPos += 50
        MyFont = New Font("Arial", 12)
        e.Graphics.DrawString("Select List for the Jobcode", MyFont, Brushes.Black, XPos, YPos)
        YPos += 100
        XPos = 10
        e.Graphics.DrawString(DG1.CurrentRow.Cells(0).Value, MyFont, Brushes.Black, XPos, YPos)
        YPos += 50
        XPos = 10
        MyFont = New Font("Arial", 12)
        e.Graphics.DrawString("Candidate Name", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 250
        e.Graphics.DrawString("Total Score", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150
        e.Graphics.DrawString("Selected", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150
       



        YPos += 25
        For Each r As DataGridViewRow In DG1.Rows
            If UCase(Trim(DG1.CurrentRow.Cells(4).Value)) = "Y" Then
                XPos = 10
                e.Graphics.DrawString(r.Cells(2).Value, MyFont, Brushes.Black, XPos, YPos)
                XPos = XPos + 250
                e.Graphics.DrawString(r.Cells(3).Value, MyFont, Brushes.Black, XPos, YPos)
                XPos = XPos + 150
                e.Graphics.DrawString(UCase(r.Cells(4).Value), MyFont, Brushes.Black, XPos, YPos)
                XPos = XPos + 150

                YPos += 25
            End If
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PP1.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("Select Jobcode,cCode,CName,TotalScore,Selected From InterviewMarksTab order by TotalScore desc", Conn)
        adp.Fill(DS1)
        DG1.DataSource = DS1.Tables(0)
        If Conn.State = ConnectionState.Open Then Conn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        For Each r As DataGridViewRow In DG1.Rows
            If Not r.Cells(0).Value = "" Then
                If Conn.State = ConnectionState.Open Then Conn.Close()
                Conn.Open()
                q1Var = "update InterviewMarksTab set Selected= '" & UCase(DG1.CurrentRow.Cells(4).Value) & "' where cName ='" & DG1.CurrentRow.Cells(2).Value & "'"
                Dim cmd1 As New SqlCommand(q1Var & q2Var, Conn)
                cmd1.ExecuteNonQuery()
            End If
        Next
        MsgBox("List is saved please proceed.")
    End Sub
End Class