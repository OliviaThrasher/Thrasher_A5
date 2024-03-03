<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PicComic = New PictureBox()
        LabelComic = New Label()
        LabelGroup = New Label()
        TextGroupSize = New TextBox()
        TextCost = New TextBox()
        LabelCost = New Label()
        Radio1Super = New RadioButton()
        GroupBox1 = New GroupBox()
        Radio3Reg = New RadioButton()
        Radio2Auto = New RadioButton()
        ButtonCalculate = New Button()
        ButtonClear = New Button()
        CType(PicComic, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PicComic
        ' 
        PicComic.BackgroundImage = CType(resources.GetObject("PicComic.BackgroundImage"), Image)
        PicComic.BackgroundImageLayout = ImageLayout.Stretch
        PicComic.Location = New Point(-2, -1)
        PicComic.Name = "PicComic"
        PicComic.Size = New Size(968, 179)
        PicComic.TabIndex = 0
        PicComic.TabStop = False
        ' 
        ' LabelComic
        ' 
        LabelComic.AutoSize = True
        LabelComic.Font = New Font("Cooper Black", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelComic.ForeColor = Color.RoyalBlue
        LabelComic.Location = New Point(53, 214)
        LabelComic.Name = "LabelComic"
        LabelComic.Size = New Size(522, 36)
        LabelComic.TabIndex = 1
        LabelComic.Text = "Comic Convention Registration"
        ' 
        ' LabelGroup
        ' 
        LabelGroup.AutoSize = True
        LabelGroup.Font = New Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelGroup.ForeColor = Color.RoyalBlue
        LabelGroup.Location = New Point(190, 269)
        LabelGroup.Name = "LabelGroup"
        LabelGroup.Size = New Size(158, 27)
        LabelGroup.TabIndex = 2
        LabelGroup.Text = "Group Size: "
        ' 
        ' TextGroupSize
        ' 
        TextGroupSize.BorderStyle = BorderStyle.FixedSingle
        TextGroupSize.Font = New Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextGroupSize.ForeColor = Color.RoyalBlue
        TextGroupSize.Location = New Point(354, 269)
        TextGroupSize.Name = "TextGroupSize"
        TextGroupSize.Size = New Size(85, 35)
        TextGroupSize.TabIndex = 3
        ' 
        ' TextCost
        ' 
        TextCost.BorderStyle = BorderStyle.FixedSingle
        TextCost.Font = New Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextCost.ForeColor = Color.RoyalBlue
        TextCost.Location = New Point(354, 449)
        TextCost.Name = "TextCost"
        TextCost.Size = New Size(135, 35)
        TextCost.TabIndex = 5
        ' 
        ' LabelCost
        ' 
        LabelCost.AutoSize = True
        LabelCost.Font = New Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelCost.ForeColor = Color.RoyalBlue
        LabelCost.Location = New Point(110, 449)
        LabelCost.Name = "LabelCost"
        LabelCost.Size = New Size(238, 27)
        LabelCost.TabIndex = 4
        LabelCost.Text = "Registration Cost: "
        ' 
        ' Radio1Super
        ' 
        Radio1Super.AutoSize = True
        Radio1Super.Checked = True
        Radio1Super.Font = New Font("Cooper Black", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Radio1Super.ForeColor = Color.RoyalBlue
        Radio1Super.Location = New Point(33, 29)
        Radio1Super.Name = "Radio1Super"
        Radio1Super.Size = New Size(403, 27)
        Radio1Super.TabIndex = 6
        Radio1Super.TabStop = True
        Radio1Super.Text = "Convention + Superhero Experience"
        Radio1Super.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.DarkOrange
        GroupBox1.Controls.Add(Radio3Reg)
        GroupBox1.Controls.Add(Radio2Auto)
        GroupBox1.Controls.Add(Radio1Super)
        GroupBox1.Font = New Font("Cooper Black", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.RoyalBlue
        GroupBox1.Location = New Point(53, 310)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(522, 133)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Select Badge Type:"
        ' 
        ' Radio3Reg
        ' 
        Radio3Reg.AutoSize = True
        Radio3Reg.Font = New Font("Cooper Black", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Radio3Reg.ForeColor = Color.RoyalBlue
        Radio3Reg.Location = New Point(33, 96)
        Radio3Reg.Name = "Radio3Reg"
        Radio3Reg.Size = New Size(152, 27)
        Radio3Reg.TabIndex = 8
        Radio3Reg.Text = "Convention"
        Radio3Reg.UseVisualStyleBackColor = True
        ' 
        ' Radio2Auto
        ' 
        Radio2Auto.AutoSize = True
        Radio2Auto.Font = New Font("Cooper Black", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Radio2Auto.ForeColor = Color.RoyalBlue
        Radio2Auto.Location = New Point(33, 63)
        Radio2Auto.Name = "Radio2Auto"
        Radio2Auto.Size = New Size(297, 27)
        Radio2Auto.TabIndex = 7
        Radio2Auto.Text = "Convention + Autographs"
        Radio2Auto.UseVisualStyleBackColor = True
        ' 
        ' ButtonCalculate
        ' 
        ButtonCalculate.BackColor = Color.RoyalBlue
        ButtonCalculate.Font = New Font("Cooper Black", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonCalculate.ForeColor = Color.DarkOrange
        ButtonCalculate.Location = New Point(53, 528)
        ButtonCalculate.Name = "ButtonCalculate"
        ButtonCalculate.Size = New Size(172, 44)
        ButtonCalculate.TabIndex = 8
        ButtonCalculate.Text = "Calculate"
        ButtonCalculate.UseVisualStyleBackColor = False
        ' 
        ' ButtonClear
        ' 
        ButtonClear.BackColor = Color.RoyalBlue
        ButtonClear.Font = New Font("Cooper Black", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonClear.ForeColor = Color.DarkOrange
        ButtonClear.Location = New Point(403, 528)
        ButtonClear.Name = "ButtonClear"
        ButtonClear.Size = New Size(172, 44)
        ButtonClear.TabIndex = 9
        ButtonClear.Text = "Clear"
        ButtonClear.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(629, 593)
        Controls.Add(ButtonClear)
        Controls.Add(ButtonCalculate)
        Controls.Add(GroupBox1)
        Controls.Add(TextCost)
        Controls.Add(LabelCost)
        Controls.Add(TextGroupSize)
        Controls.Add(LabelGroup)
        Controls.Add(LabelComic)
        Controls.Add(PicComic)
        Name = "Form1"
        Text = "Comic Convention Registration"
        CType(PicComic, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PicComic As PictureBox
    Friend WithEvents LabelComic As Label
    Friend WithEvents LabelGroup As Label
    Friend WithEvents TextGroupSize As TextBox
    Friend WithEvents TextCost As TextBox
    Friend WithEvents LabelCost As Label
    Friend WithEvents Radio1Super As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Radio2Auto As RadioButton
    Friend WithEvents Radio3Reg As RadioButton
    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents ButtonClear As Button

End Class
