<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotification
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
                If AnimationControl IsNot Nothing Then
                    AnimationControl.Dispose()
                    AnimationControl = Nothing
                End If
                If LifeTime IsNot Nothing Then
                    LifeTime.Dispose()
                    LifeTime = Nothing
                End If
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.NotificationUI = New DevExpress.XtraEditors.GroupControl()
        Me.lblNotificationMessage = New DevExpress.XtraEditors.LabelControl()
        Me.lblClose = New DevExpress.XtraEditors.LabelControl()
        Me.NotificationIcon = New DevExpress.XtraEditors.PictureEdit()
        Me.lblHeading = New DevExpress.XtraEditors.LabelControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.NotificationUI,System.ComponentModel.ISupportInitialize).BeginInit
        Me.NotificationUI.SuspendLayout
        CType(Me.NotificationIcon.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'NotificationUI
        '
        Me.NotificationUI.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NotificationUI.Appearance.BackColor2 = System.Drawing.Color.White
        Me.NotificationUI.Appearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.NotificationUI.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.NotificationUI.Appearance.Options.UseBackColor = true
        Me.NotificationUI.Appearance.Options.UseBorderColor = true
        Me.NotificationUI.Appearance.Options.UseFont = true
        Me.NotificationUI.AppearanceCaption.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.NotificationUI.AppearanceCaption.Options.UseFont = true
        Me.NotificationUI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.NotificationUI.Controls.Add(Me.lblNotificationMessage)
        Me.NotificationUI.Controls.Add(Me.lblClose)
        Me.NotificationUI.Controls.Add(Me.NotificationIcon)
        Me.NotificationUI.Controls.Add(Me.lblHeading)
        Me.NotificationUI.Location = New System.Drawing.Point(0, 0)
        Me.NotificationUI.Name = "NotificationUI"
        Me.NotificationUI.Size = New System.Drawing.Size(413, 127)
        Me.NotificationUI.TabIndex = 0
        Me.NotificationUI.Text = "NotifyTitle"
        '
        'lblNotificationMessage
        '
        Me.lblNotificationMessage.Appearance.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblNotificationMessage.Appearance.Options.UseFont = true
        Me.lblNotificationMessage.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 9.75!)
        Me.lblNotificationMessage.AppearanceDisabled.Options.UseFont = true
        Me.lblNotificationMessage.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 9.75!)
        Me.lblNotificationMessage.AppearanceHovered.Options.UseFont = true
        Me.lblNotificationMessage.AppearancePressed.Font = New System.Drawing.Font("Cambria", 9.75!)
        Me.lblNotificationMessage.AppearancePressed.Options.UseFont = true
        Me.lblNotificationMessage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblNotificationMessage.Location = New System.Drawing.Point(107, 50)
        Me.lblNotificationMessage.Name = "lblNotificationMessage"
        Me.lblNotificationMessage.Size = New System.Drawing.Size(290, 15)
        Me.lblNotificationMessage.TabIndex = 4
        Me.lblNotificationMessage.Text = "lblNotificationControl"
        '
        'lblClose
        '
        Me.lblClose.Appearance.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblClose.Appearance.Options.UseFont = true
        Me.lblClose.AppearanceDisabled.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblClose.AppearanceDisabled.Options.UseFont = true
        Me.lblClose.AppearanceHovered.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblClose.AppearanceHovered.Options.UseFont = true
        Me.lblClose.AppearancePressed.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblClose.AppearancePressed.Options.UseFont = true
        Me.lblClose.Location = New System.Drawing.Point(394, 4)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(14, 13)
        Me.lblClose.TabIndex = 3
        Me.lblClose.Text = "  X  "
        '
        'NotificationIcon
        '
        Me.NotificationIcon.Cursor = System.Windows.Forms.Cursors.Default
        Me.NotificationIcon.EditValue = Global.SwatIncNotifications.My.Resources.Resources.SocketDisconnected
        Me.NotificationIcon.Location = New System.Drawing.Point(5, 25)
        Me.NotificationIcon.Name = "NotificationIcon"
        Me.NotificationIcon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.NotificationIcon.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.NotificationIcon.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.NotificationIcon.Properties.ZoomAccelerationFactor = 1R
        Me.NotificationIcon.Size = New System.Drawing.Size(91, 97)
        Me.NotificationIcon.TabIndex = 1
        '
        'lblHeading
        '
        Me.lblHeading.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblHeading.Appearance.Options.UseFont = true
        Me.lblHeading.AppearanceDisabled.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblHeading.AppearanceDisabled.Options.UseFont = true
        Me.lblHeading.AppearanceHovered.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblHeading.AppearanceHovered.Options.UseFont = true
        Me.lblHeading.AppearancePressed.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblHeading.AppearancePressed.Options.UseFont = true
        Me.lblHeading.LineVisible = true
        Me.lblHeading.Location = New System.Drawing.Point(107, 25)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(80, 19)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "labelHeading"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'frmNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 128)
        Me.Controls.Add(Me.NotificationUI)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNotification"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmNotification"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.NotificationUI,System.ComponentModel.ISupportInitialize).EndInit
        Me.NotificationUI.ResumeLayout(false)
        Me.NotificationUI.PerformLayout
        CType(Me.NotificationIcon.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents NotificationUI As DevExpress.XtraEditors.GroupControl
    Friend WithEvents NotificationIcon As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lblHeading As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lblClose As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNotificationMessage As DevExpress.XtraEditors.LabelControl
End Class
