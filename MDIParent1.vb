Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub MDIParent1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CourseDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseDetailsToolStripMenuItem.Click
        CourseDetForm.MdiParent = Me
        CourseDetForm.Show()
    End Sub

    Private Sub BranchDetailsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BranchDetailsToolStripMenuItem.Click
        BranchDetForm.MdiParent = Me
        BranchDetForm.Show()
    End Sub

    Private Sub AdditionalCourseDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdditionalCourseDetailsToolStripMenuItem.Click
        AddCourseForm.MdiParent = Me
        AddCourseForm.Show()
    End Sub

    Private Sub DesignationDetailsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DesignationDetailsToolStripMenuItem.Click
        DesignationForm.MdiParent = Me
        DesignationForm.Show()
    End Sub

    Private Sub DepartmentDetailsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DepartmentDetailsToolStripMenuItem.Click
        DepartmentForm.MdiParent = Me
        DepartmentForm.Show()
    End Sub

    Private Sub JobOpeningsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JobOpeningsToolStripMenuItem.Click
        JobOpeningsForm.MdiParent = Me
        JobOpeningsForm.Show()
    End Sub



    Private Sub ResumeEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumeEntryToolStripMenuItem.Click
        ResumeEntry1Form.MdiParent = Me
        ResumeEntry1Form.Show()
    End Sub

    Private Sub ResumeSearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumeSearchToolStripMenuItem.Click
        ResumeMatchRep.MdiParent = Me
        ResumeMatchRep.Show()
    End Sub


    Private Sub InterviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InterviewToolStripMenuItem.Click
        InterviewForm.MdiParent = Me
        InterviewForm.Show()
    End Sub

    Private Sub SelectionToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SelectionToolStripMenuItem1.Click
        SelectionForm.MdiParent = Me
        SelectionForm.Show()
    End Sub

    Private Sub EmployeeListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeListToolStripMenuItem.Click
        EmpListForm.MdiParent = Me
        EmpListForm.Show()
    End Sub

    Private Sub ResumeListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumeListToolStripMenuItem.Click
        ResumeListForm.MdiParent = Me
        ResumeListForm.Show()
    End Sub

    Private Sub EmployeeDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeDetailsToolStripMenuItem.Click
        EmpDetForm.MdiParent = Me
        EmpDetForm.Show()
    End Sub

    Private Sub EmployeeSalaryDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeSalaryDetailsToolStripMenuItem.Click
        EmpSalaryDetailsForm.MdiParent = Me
        EmpSalaryDetailsForm.Show()
    End Sub
End Class
