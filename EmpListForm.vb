Imports System.Data.SqlClient
Public Class EmpListForm
    Dim pkVar As Long
    Private Sub BuyerRepForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized


    End Sub


    Private Sub butClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClose.Click
        Me.Close()
    End Sub



    Private Sub butList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butList.Click
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("Select * From empDetTab order by empcode", Conn)

        adp.Fill(DS1)
        DG1.DataSource = DS1.Tables(0)
        If Conn.State = ConnectionState.Open Then Conn.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim XPos, YPos As Long
        YPos = 50
        Dim MyFont As New Font("Arial", 18)
        XPos = 10
        e.Graphics.DrawString("HR management", MyFont, Brushes.Black, XPos, YPos)
        YPos += 50
        MyFont = New Font("Arial", 12)
        e.Graphics.DrawString("No 2342, Vijayanagr, Bangalore", MyFont, Brushes.Black, XPos, YPos)
        YPos += 100
        XPos = 10
        e.Graphics.DrawString("Emp Report", MyFont, Brushes.Black, XPos, YPos)
        YPos += 50
        XPos = 10
        MyFont = New Font("Arial", 12)
        e.Graphics.DrawString("empNo", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 50
        e.Graphics.DrawString("emp Name", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150
        e.Graphics.DrawString("phone No", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150
        e.Graphics.DrawString("designation", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150
        e.Graphics.DrawString("Branch", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150



        YPos += 25
        For Each r As DataGridViewRow In DG1.Rows
            XPos = 10
            e.Graphics.DrawString(r.Cells(0).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 50
            e.Graphics.DrawString((r.Cells(1).Value), MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150
            e.Graphics.DrawString(r.Cells(2).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150
            e.Graphics.DrawString(r.Cells(3).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150
            e.Graphics.DrawString(r.Cells(4).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150

            YPos += 25
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PP1.ShowDialog()
    End Sub

    Private Sub PP1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles PP1.Disposed
        PP1.Close()
        PrintDocument1.Dispose()
    End Sub
End Class
