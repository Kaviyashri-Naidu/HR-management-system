<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MasterEntriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CourseDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BranchDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdditionalCourseDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DesignationDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DepartmentDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.JobOpeningsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResumeEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResumeSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InterviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SelectionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeSalaryDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResumeListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 536)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 18, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1121, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(38, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterEntriesToolStripMenuItem, Me.JobOpeningsToolStripMenuItem, Me.ResumeEntryToolStripMenuItem, Me.ResumeSearchToolStripMenuItem, Me.InterviewToolStripMenuItem, Me.SelectionToolStripMenuItem1, Me.EmployeeToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1121, 25)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterEntriesToolStripMenuItem
        '
        Me.MasterEntriesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CourseDetailsToolStripMenuItem, Me.BranchDetailsToolStripMenuItem, Me.AdditionalCourseDetailsToolStripMenuItem, Me.DesignationDetailsToolStripMenuItem, Me.DepartmentDetailsToolStripMenuItem})
        Me.MasterEntriesToolStripMenuItem.Name = "MasterEntriesToolStripMenuItem"
        Me.MasterEntriesToolStripMenuItem.Size = New System.Drawing.Size(121, 21)
        Me.MasterEntriesToolStripMenuItem.Text = "Master Entries"
        '
        'CourseDetailsToolStripMenuItem
        '
        Me.CourseDetailsToolStripMenuItem.Name = "CourseDetailsToolStripMenuItem"
        Me.CourseDetailsToolStripMenuItem.Size = New System.Drawing.Size(266, 22)
        Me.CourseDetailsToolStripMenuItem.Text = "Course Details"
        '
        'BranchDetailsToolStripMenuItem
        '
        Me.BranchDetailsToolStripMenuItem.Name = "BranchDetailsToolStripMenuItem"
        Me.BranchDetailsToolStripMenuItem.Size = New System.Drawing.Size(266, 22)
        Me.BranchDetailsToolStripMenuItem.Text = "Branch Details"
        '
        'AdditionalCourseDetailsToolStripMenuItem
        '
        Me.AdditionalCourseDetailsToolStripMenuItem.Name = "AdditionalCourseDetailsToolStripMenuItem"
        Me.AdditionalCourseDetailsToolStripMenuItem.Size = New System.Drawing.Size(266, 22)
        Me.AdditionalCourseDetailsToolStripMenuItem.Text = "Additional Course Details"
        '
        'DesignationDetailsToolStripMenuItem
        '
        Me.DesignationDetailsToolStripMenuItem.Name = "DesignationDetailsToolStripMenuItem"
        Me.DesignationDetailsToolStripMenuItem.Size = New System.Drawing.Size(266, 22)
        Me.DesignationDetailsToolStripMenuItem.Text = "Designation Details"
        '
        'DepartmentDetailsToolStripMenuItem
        '
        Me.DepartmentDetailsToolStripMenuItem.Name = "DepartmentDetailsToolStripMenuItem"
        Me.DepartmentDetailsToolStripMenuItem.Size = New System.Drawing.Size(266, 22)
        Me.DepartmentDetailsToolStripMenuItem.Text = "Department Details"
        '
        'JobOpeningsToolStripMenuItem
        '
        Me.JobOpeningsToolStripMenuItem.Name = "JobOpeningsToolStripMenuItem"
        Me.JobOpeningsToolStripMenuItem.Size = New System.Drawing.Size(115, 21)
        Me.JobOpeningsToolStripMenuItem.Text = "Job Openings"
        '
        'ResumeEntryToolStripMenuItem
        '
        Me.ResumeEntryToolStripMenuItem.Name = "ResumeEntryToolStripMenuItem"
        Me.ResumeEntryToolStripMenuItem.Size = New System.Drawing.Size(119, 21)
        Me.ResumeEntryToolStripMenuItem.Text = "Resume Entry"
        '
        'ResumeSearchToolStripMenuItem
        '
        Me.ResumeSearchToolStripMenuItem.Name = "ResumeSearchToolStripMenuItem"
        Me.ResumeSearchToolStripMenuItem.Size = New System.Drawing.Size(129, 21)
        Me.ResumeSearchToolStripMenuItem.Text = "Resume Search"
        '
        'InterviewToolStripMenuItem
        '
        Me.InterviewToolStripMenuItem.Name = "InterviewToolStripMenuItem"
        Me.InterviewToolStripMenuItem.Size = New System.Drawing.Size(84, 21)
        Me.InterviewToolStripMenuItem.Text = "Interview"
        '
        'SelectionToolStripMenuItem1
        '
        Me.SelectionToolStripMenuItem1.Name = "SelectionToolStripMenuItem1"
        Me.SelectionToolStripMenuItem1.Size = New System.Drawing.Size(83, 21)
        Me.SelectionToolStripMenuItem1.Text = "Selection"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeDetailsToolStripMenuItem, Me.EmployeeSalaryDetailsToolStripMenuItem})
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(87, 21)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'EmployeeDetailsToolStripMenuItem
        '
        Me.EmployeeDetailsToolStripMenuItem.Name = "EmployeeDetailsToolStripMenuItem"
        Me.EmployeeDetailsToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.EmployeeDetailsToolStripMenuItem.Text = "Employee Details"
        '
        'EmployeeSalaryDetailsToolStripMenuItem
        '
        Me.EmployeeSalaryDetailsToolStripMenuItem.Name = "EmployeeSalaryDetailsToolStripMenuItem"
        Me.EmployeeSalaryDetailsToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.EmployeeSalaryDetailsToolStripMenuItem.Text = "Employee Salary Details"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeListToolStripMenuItem, Me.ResumeListToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(76, 21)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'EmployeeListToolStripMenuItem
        '
        Me.EmployeeListToolStripMenuItem.Name = "EmployeeListToolStripMenuItem"
        Me.EmployeeListToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.EmployeeListToolStripMenuItem.Text = "Employee List"
        '
        'ResumeListToolStripMenuItem
        '
        Me.ResumeListToolStripMenuItem.Name = "ResumeListToolStripMenuItem"
        Me.ResumeListToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ResumeListToolStripMenuItem.Text = "Resume List"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 514)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 18, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1121, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 558)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MDIParent1"
        Me.Text = "HR Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterEntriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents CourseDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BranchDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdditionalCourseDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesignationDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JobOpeningsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumeEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumeSearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InterviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectionToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeSalaryDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumeListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
