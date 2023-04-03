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
        Me.TextBoxInput = New System.Windows.Forms.TextBox()
        Me.GroupBoxInput = New System.Windows.Forms.GroupBox()
        Me.RadioButtonInputCarats = New System.Windows.Forms.RadioButton()
        Me.RadioButtonInputOunces = New System.Windows.Forms.RadioButton()
        Me.RadioButtonInputPounds = New System.Windows.Forms.RadioButton()
        Me.RadioButtonInputGrams = New System.Windows.Forms.RadioButton()
        Me.RadioButtonInputKilos = New System.Windows.Forms.RadioButton()
        Me.RadioButtonInputTonnes = New System.Windows.Forms.RadioButton()
        Me.GroupBoxOutput = New System.Windows.Forms.GroupBox()
        Me.RadioButtonOutputCarats = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOutputOunces = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOutputPounds = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOutputGrams = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOutputKilos = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOutputTonnes = New System.Windows.Forms.RadioButton()
        Me.TextBoxOutputs = New System.Windows.Forms.TextBox()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBoxInput.SuspendLayout()
        Me.GroupBoxOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxInput
        '
        Me.TextBoxInput.Location = New System.Drawing.Point(12, 12)
        Me.TextBoxInput.Name = "TextBoxInput"
        Me.TextBoxInput.Size = New System.Drawing.Size(125, 27)
        Me.TextBoxInput.TabIndex = 0
        '
        'GroupBoxInput
        '
        Me.GroupBoxInput.Controls.Add(Me.RadioButtonInputCarats)
        Me.GroupBoxInput.Controls.Add(Me.RadioButtonInputOunces)
        Me.GroupBoxInput.Controls.Add(Me.RadioButtonInputPounds)
        Me.GroupBoxInput.Controls.Add(Me.RadioButtonInputGrams)
        Me.GroupBoxInput.Controls.Add(Me.RadioButtonInputKilos)
        Me.GroupBoxInput.Controls.Add(Me.RadioButtonInputTonnes)
        Me.GroupBoxInput.Location = New System.Drawing.Point(12, 45)
        Me.GroupBoxInput.Name = "GroupBoxInput"
        Me.GroupBoxInput.Size = New System.Drawing.Size(125, 211)
        Me.GroupBoxInput.TabIndex = 2
        Me.GroupBoxInput.TabStop = False
        Me.GroupBoxInput.Text = "Inouts"
        '
        'RadioButtonInputCarats
        '
        Me.RadioButtonInputCarats.AutoSize = True
        Me.RadioButtonInputCarats.Location = New System.Drawing.Point(6, 176)
        Me.RadioButtonInputCarats.Name = "RadioButtonInputCarats"
        Me.RadioButtonInputCarats.Size = New System.Drawing.Size(71, 24)
        Me.RadioButtonInputCarats.TabIndex = 5
        Me.RadioButtonInputCarats.TabStop = True
        Me.RadioButtonInputCarats.Text = "Carats"
        Me.RadioButtonInputCarats.UseVisualStyleBackColor = True
        '
        'RadioButtonInputOunces
        '
        Me.RadioButtonInputOunces.AutoSize = True
        Me.RadioButtonInputOunces.Location = New System.Drawing.Point(6, 146)
        Me.RadioButtonInputOunces.Name = "RadioButtonInputOunces"
        Me.RadioButtonInputOunces.Size = New System.Drawing.Size(78, 24)
        Me.RadioButtonInputOunces.TabIndex = 4
        Me.RadioButtonInputOunces.TabStop = True
        Me.RadioButtonInputOunces.Text = "Ounces"
        Me.RadioButtonInputOunces.UseVisualStyleBackColor = True
        '
        'RadioButtonInputPounds
        '
        Me.RadioButtonInputPounds.AutoSize = True
        Me.RadioButtonInputPounds.Location = New System.Drawing.Point(6, 116)
        Me.RadioButtonInputPounds.Name = "RadioButtonInputPounds"
        Me.RadioButtonInputPounds.Size = New System.Drawing.Size(77, 24)
        Me.RadioButtonInputPounds.TabIndex = 3
        Me.RadioButtonInputPounds.TabStop = True
        Me.RadioButtonInputPounds.Text = "Pounds"
        Me.RadioButtonInputPounds.UseVisualStyleBackColor = True
        '
        'RadioButtonInputGrams
        '
        Me.RadioButtonInputGrams.AutoSize = True
        Me.RadioButtonInputGrams.Location = New System.Drawing.Point(6, 86)
        Me.RadioButtonInputGrams.Name = "RadioButtonInputGrams"
        Me.RadioButtonInputGrams.Size = New System.Drawing.Size(72, 24)
        Me.RadioButtonInputGrams.TabIndex = 2
        Me.RadioButtonInputGrams.TabStop = True
        Me.RadioButtonInputGrams.Text = "Grams"
        Me.RadioButtonInputGrams.UseVisualStyleBackColor = True
        '
        'RadioButtonInputKilos
        '
        Me.RadioButtonInputKilos.AutoSize = True
        Me.RadioButtonInputKilos.Location = New System.Drawing.Point(6, 56)
        Me.RadioButtonInputKilos.Name = "RadioButtonInputKilos"
        Me.RadioButtonInputKilos.Size = New System.Drawing.Size(97, 24)
        Me.RadioButtonInputKilos.TabIndex = 1
        Me.RadioButtonInputKilos.TabStop = True
        Me.RadioButtonInputKilos.Text = "Kilograms"
        Me.RadioButtonInputKilos.UseVisualStyleBackColor = True
        '
        'RadioButtonInputTonnes
        '
        Me.RadioButtonInputTonnes.AutoSize = True
        Me.RadioButtonInputTonnes.Location = New System.Drawing.Point(6, 26)
        Me.RadioButtonInputTonnes.Name = "RadioButtonInputTonnes"
        Me.RadioButtonInputTonnes.Size = New System.Drawing.Size(76, 24)
        Me.RadioButtonInputTonnes.TabIndex = 0
        Me.RadioButtonInputTonnes.TabStop = True
        Me.RadioButtonInputTonnes.Text = "Tonnes"
        Me.RadioButtonInputTonnes.UseVisualStyleBackColor = True
        '
        'GroupBoxOutput
        '
        Me.GroupBoxOutput.Controls.Add(Me.RadioButtonOutputCarats)
        Me.GroupBoxOutput.Controls.Add(Me.RadioButtonOutputOunces)
        Me.GroupBoxOutput.Controls.Add(Me.RadioButtonOutputPounds)
        Me.GroupBoxOutput.Controls.Add(Me.RadioButtonOutputGrams)
        Me.GroupBoxOutput.Controls.Add(Me.RadioButtonOutputKilos)
        Me.GroupBoxOutput.Controls.Add(Me.RadioButtonOutputTonnes)
        Me.GroupBoxOutput.Location = New System.Drawing.Point(143, 45)
        Me.GroupBoxOutput.Name = "GroupBoxOutput"
        Me.GroupBoxOutput.Size = New System.Drawing.Size(125, 211)
        Me.GroupBoxOutput.TabIndex = 4
        Me.GroupBoxOutput.TabStop = False
        Me.GroupBoxOutput.Text = "Outputs"
        '
        'RadioButtonOutputCarats
        '
        Me.RadioButtonOutputCarats.AutoSize = True
        Me.RadioButtonOutputCarats.Location = New System.Drawing.Point(6, 176)
        Me.RadioButtonOutputCarats.Name = "RadioButtonOutputCarats"
        Me.RadioButtonOutputCarats.Size = New System.Drawing.Size(71, 24)
        Me.RadioButtonOutputCarats.TabIndex = 5
        Me.RadioButtonOutputCarats.TabStop = True
        Me.RadioButtonOutputCarats.Text = "Carats"
        Me.RadioButtonOutputCarats.UseVisualStyleBackColor = True
        '
        'RadioButtonOutputOunces
        '
        Me.RadioButtonOutputOunces.AutoSize = True
        Me.RadioButtonOutputOunces.Location = New System.Drawing.Point(6, 146)
        Me.RadioButtonOutputOunces.Name = "RadioButtonOutputOunces"
        Me.RadioButtonOutputOunces.Size = New System.Drawing.Size(78, 24)
        Me.RadioButtonOutputOunces.TabIndex = 4
        Me.RadioButtonOutputOunces.TabStop = True
        Me.RadioButtonOutputOunces.Text = "Ounces"
        Me.RadioButtonOutputOunces.UseVisualStyleBackColor = True
        '
        'RadioButtonOutputPounds
        '
        Me.RadioButtonOutputPounds.AutoSize = True
        Me.RadioButtonOutputPounds.Location = New System.Drawing.Point(6, 116)
        Me.RadioButtonOutputPounds.Name = "RadioButtonOutputPounds"
        Me.RadioButtonOutputPounds.Size = New System.Drawing.Size(77, 24)
        Me.RadioButtonOutputPounds.TabIndex = 3
        Me.RadioButtonOutputPounds.TabStop = True
        Me.RadioButtonOutputPounds.Text = "Pounds"
        Me.RadioButtonOutputPounds.UseVisualStyleBackColor = True
        '
        'RadioButtonOutputGrams
        '
        Me.RadioButtonOutputGrams.AutoSize = True
        Me.RadioButtonOutputGrams.Location = New System.Drawing.Point(6, 86)
        Me.RadioButtonOutputGrams.Name = "RadioButtonOutputGrams"
        Me.RadioButtonOutputGrams.Size = New System.Drawing.Size(72, 24)
        Me.RadioButtonOutputGrams.TabIndex = 2
        Me.RadioButtonOutputGrams.TabStop = True
        Me.RadioButtonOutputGrams.Text = "Grams"
        Me.RadioButtonOutputGrams.UseVisualStyleBackColor = True
        '
        'RadioButtonOutputKilos
        '
        Me.RadioButtonOutputKilos.AutoSize = True
        Me.RadioButtonOutputKilos.Location = New System.Drawing.Point(6, 56)
        Me.RadioButtonOutputKilos.Name = "RadioButtonOutputKilos"
        Me.RadioButtonOutputKilos.Size = New System.Drawing.Size(97, 24)
        Me.RadioButtonOutputKilos.TabIndex = 1
        Me.RadioButtonOutputKilos.TabStop = True
        Me.RadioButtonOutputKilos.Text = "Kilograms"
        Me.RadioButtonOutputKilos.UseVisualStyleBackColor = True
        '
        'RadioButtonOutputTonnes
        '
        Me.RadioButtonOutputTonnes.AutoSize = True
        Me.RadioButtonOutputTonnes.Location = New System.Drawing.Point(6, 26)
        Me.RadioButtonOutputTonnes.Name = "RadioButtonOutputTonnes"
        Me.RadioButtonOutputTonnes.Size = New System.Drawing.Size(76, 24)
        Me.RadioButtonOutputTonnes.TabIndex = 0
        Me.RadioButtonOutputTonnes.TabStop = True
        Me.RadioButtonOutputTonnes.Text = "Tonnes"
        Me.RadioButtonOutputTonnes.UseVisualStyleBackColor = True
        '
        'TextBoxOutputs
        '
        Me.TextBoxOutputs.Location = New System.Drawing.Point(143, 12)
        Me.TextBoxOutputs.Name = "TextBoxOutputs"
        Me.TextBoxOutputs.Size = New System.Drawing.Size(125, 27)
        Me.TextBoxOutputs.TabIndex = 3
        '
        'Calculate
        '
        Me.Calculate.Location = New System.Drawing.Point(12, 262)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(125, 29)
        Me.Calculate.TabIndex = 5
        Me.Calculate.Text = "Calculate"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(143, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "History"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 302)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.GroupBoxOutput)
        Me.Controls.Add(Me.TextBoxOutputs)
        Me.Controls.Add(Me.GroupBoxInput)
        Me.Controls.Add(Me.TextBoxInput)
        Me.Name = "Form1"
        Me.Text = "Convertor"
        Me.GroupBoxInput.ResumeLayout(False)
        Me.GroupBoxInput.PerformLayout()
        Me.GroupBoxOutput.ResumeLayout(False)
        Me.GroupBoxOutput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxInput As TextBox
    Friend WithEvents GroupBoxInput As GroupBox
    Friend WithEvents RadioButtonInputCarats As RadioButton
    Friend WithEvents RadioButtonInputOunces As RadioButton
    Friend WithEvents RadioButtonInputPounds As RadioButton
    Friend WithEvents RadioButtonInputGrams As RadioButton
    Friend WithEvents RadioButtonInputKilos As RadioButton
    Friend WithEvents RadioButtonInputTonnes As RadioButton
    Friend WithEvents GroupBoxOutput As GroupBox
    Friend WithEvents RadioButtonOutputCarats As RadioButton
    Friend WithEvents RadioButtonOutputOunces As RadioButton
    Friend WithEvents RadioButtonOutputPounds As RadioButton
    Friend WithEvents RadioButtonOutputGrams As RadioButton
    Friend WithEvents RadioButtonOutputKilos As RadioButton
    Friend WithEvents RadioButtonOutputTonnes As RadioButton
    Friend WithEvents TextBoxOutputs As TextBox
    Friend WithEvents Calculate As Button
    Friend WithEvents Button1 As Button
End Class
