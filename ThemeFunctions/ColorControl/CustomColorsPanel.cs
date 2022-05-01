using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using ThemeFunctions.Colors;

namespace ThemeFunctions
{
    /// <summary>
    ///   User control that enables to define a custom color based on alpha, 
    ///   red, green and blue component. Control displays current color in 
    ///   a box.
    /// </summary>
    [ToolboxItem(true)]
    public class CustomColorsPanel : System.Windows.Forms.UserControl
    {

        /// <summary>
        /// Event raised when any of the TrackBar values are changed either by the user, or programatically.
        /// </summary>
        public event TrackBarChangedEventHandler TrackBarChanged;

        #region Window Controls

        private SamplePictureBox m_pictureBoxColorSample;

        private System.Windows.Forms.Label m_labelAlpha;
        private System.Windows.Forms.TrackBar m_trackBarAlpha;
        private ARGBTextBox m_textBoxAlpha;

        private System.Windows.Forms.Label m_labelRed;
        private System.Windows.Forms.TrackBar m_trackBarRed;
        private ARGBTextBox m_textBoxRed;

        private System.Windows.Forms.Label m_labelBlue;
        private System.Windows.Forms.TrackBar m_trackBarBlue;
        private ARGBTextBox m_textBoxBlue;

        private System.Windows.Forms.Label m_labelGreen;
        private System.Windows.Forms.TrackBar m_trackBarGreen;
        private ARGBTextBox m_textBoxGreen;

        #endregion // Window Controls

        private bool _allowAlpha = true;
        private int _trackBarHeight = 20;
        private Label label1;
        private Label llblHexColor;

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public CustomColorsPanel()
        {
            InitializeComponent();
            Color = Color.FromArgb(255, 255, 255, 255);
        }

        /// <summary>
        ///   Height of trackbars used for individual colors.
        /// </summary>
        public int TrackBarHeight
        {
            get { return this._trackBarHeight; }
            set
            {
                this._trackBarHeight = value;
                ResetTrackBars();
            }
        }

        /// <summary>
        ///   Gets or sets the current color.
        /// </summary>
        public Color Color
        {
            get
            {
                if (!_allowAlpha)
                {
                    return Color.FromArgb(m_trackBarRed.Value, m_trackBarGreen.Value, m_trackBarBlue.Value);
                }
                return Color.FromArgb(m_trackBarAlpha.Value, m_trackBarRed.Value, m_trackBarGreen.Value, m_trackBarBlue.Value);
            }

            set
            {
                if (!_allowAlpha)
                {
                    m_textBoxAlpha.Value = 255;
                }
                else
                {
                    m_textBoxAlpha.Value = value.A;
                }
                m_textBoxRed.Value = value.R;
                m_textBoxGreen.Value = value.G;
                m_textBoxBlue.Value = value.B;
            }
        }

        /// <summary>
        ///	Allow selection of colors with less than full Alpha (255) 
        /// </summary>
        public bool AllowTransparent
        {
            get { return _allowAlpha; }
            set
            {
                _allowAlpha = value;
                if (!_allowAlpha) { m_textBoxAlpha.Value = 255; }
                m_textBoxAlpha.ReadOnly = !_allowAlpha;
                m_trackBarAlpha.Enabled = _allowAlpha;
            }
        }

        /// <summary>
        /// Gets and Sets background appearance of the color sample box.
        /// </summary>
        public SampleBackground CustomColorSampleBackground
        {
            get { return m_pictureBoxColorSample.Background; }
            set { m_pictureBoxColorSample.Background = value; }
        }

        /// <summary>
        /// Gets and Sets appearance of the sample color in the sample box.
        /// </summary>
        public ColorSamplePosition CustomColorSamplePosition
        {
            get { return m_pictureBoxColorSample.SamplePosition; }
            set { m_pictureBoxColorSample.SamplePosition = value; }
        }


        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">Boolean value indicating whether control is in the midst of disposing resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        ///// <summary>
        ///// Overrides OnSizeChanged event handler in order to reposition controls.
        ///// </summary>
        ///// <param name="e">System.EventArgs.</param>
        //protected override void OnSizeChanged(EventArgs e)
        //{
        //	base.OnSizeChanged(e);

        //	m_pictureBoxColorSample.Top = this.Height / 20;
        //	int dy = Height / 8;
        //	int y = Height / 4;
        //	m_labelAlpha.Top = m_trackBarAlpha.Top = m_textBoxAlpha.Top = y;
        //	y += dy;
        //	m_labelRed.Top = m_trackBarRed.Top = m_textBoxRed.Top = y;
        //	y += dy;
        //	m_labelGreen.Top = m_trackBarGreen.Top = m_textBoxGreen.Top = y;
        //	y += dy;
        //	m_labelBlue.Top = m_trackBarBlue.Top = m_textBoxBlue.Top = y;
        //	m_buttonOK.Top = (this.Height + m_trackBarBlue.Bottom - m_buttonOK.Height) / 2;
        //	m_buttonOK.Left = (this.Width - m_buttonOK.Width) / 2;
        //	ResetTrackBars();
        //}

        /// <summary>
        /// Called to prevent trackbars resize.
        /// </summary>
        /// <param name="levent">The System.Windows.Forms.LayoutEventArgs</c></param>
        protected override void OnLayout(LayoutEventArgs levent)
        {
            ResetTrackBars();
            base.OnLayout(levent);
        }


        /// <summary>
        /// Resets trackbars height. Workaround for designer resetting height to default value(42).
        /// </summary>
        private void ResetTrackBars()
        {
            m_trackBarAlpha.Height = m_trackBarRed.Height = m_trackBarGreen.Height = m_trackBarBlue.Height = TrackBarHeight;
        }

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_labelAlpha = new System.Windows.Forms.Label();
            this.m_trackBarAlpha = new System.Windows.Forms.TrackBar();
            this.m_labelBlue = new System.Windows.Forms.Label();
            this.m_labelGreen = new System.Windows.Forms.Label();
            this.m_labelRed = new System.Windows.Forms.Label();
            this.m_trackBarBlue = new System.Windows.Forms.TrackBar();
            this.m_trackBarGreen = new System.Windows.Forms.TrackBar();
            this.m_trackBarRed = new System.Windows.Forms.TrackBar();
            this.m_textBoxAlpha = new ThemeFunctions.ARGBTextBox();
            this.m_textBoxBlue = new ThemeFunctions.ARGBTextBox();
            this.m_textBoxGreen = new ThemeFunctions.ARGBTextBox();
            this.m_textBoxRed = new ThemeFunctions.ARGBTextBox();
            this.m_pictureBoxColorSample = new ThemeFunctions.SamplePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.llblHexColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxColorSample)).BeginInit();
            this.SuspendLayout();
            // 
            // m_labelAlpha
            // 
            this.m_labelAlpha.AutoSize = true;
            this.m_labelAlpha.BackColor = System.Drawing.Color.Transparent;
            this.m_labelAlpha.Location = new System.Drawing.Point(11, 75);
            this.m_labelAlpha.Name = "m_labelAlpha";
            this.m_labelAlpha.Size = new System.Drawing.Size(22, 16);
            this.m_labelAlpha.TabIndex = 0;
            this.m_labelAlpha.Text = "&A:";
            this.m_labelAlpha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_trackBarAlpha
            // 
            this.m_trackBarAlpha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_trackBarAlpha.AutoSize = false;
            this.m_trackBarAlpha.LargeChange = 16;
            this.m_trackBarAlpha.Location = new System.Drawing.Point(28, 78);
            this.m_trackBarAlpha.Maximum = 255;
            this.m_trackBarAlpha.Name = "m_trackBarAlpha";
            this.m_trackBarAlpha.Size = new System.Drawing.Size(265, 20);
            this.m_trackBarAlpha.TabIndex = 1;
            this.m_trackBarAlpha.TickFrequency = 32;
            this.m_trackBarAlpha.Value = 255;
            this.m_trackBarAlpha.Scroll += new System.EventHandler(this.m_trackBarAlpha_Scroll);
            // 
            // m_labelBlue
            // 
            this.m_labelBlue.AutoSize = true;
            this.m_labelBlue.BackColor = System.Drawing.Color.Transparent;
            this.m_labelBlue.Location = new System.Drawing.Point(11, 153);
            this.m_labelBlue.Name = "m_labelBlue";
            this.m_labelBlue.Size = new System.Drawing.Size(21, 16);
            this.m_labelBlue.TabIndex = 9;
            this.m_labelBlue.Text = "&B:";
            this.m_labelBlue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_labelGreen
            // 
            this.m_labelGreen.AutoSize = true;
            this.m_labelGreen.BackColor = System.Drawing.Color.Transparent;
            this.m_labelGreen.Location = new System.Drawing.Point(11, 127);
            this.m_labelGreen.Name = "m_labelGreen";
            this.m_labelGreen.Size = new System.Drawing.Size(22, 16);
            this.m_labelGreen.TabIndex = 6;
            this.m_labelGreen.Text = "&G:";
            this.m_labelGreen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_labelRed
            // 
            this.m_labelRed.AutoSize = true;
            this.m_labelRed.BackColor = System.Drawing.Color.Transparent;
            this.m_labelRed.Location = new System.Drawing.Point(11, 101);
            this.m_labelRed.Name = "m_labelRed";
            this.m_labelRed.Size = new System.Drawing.Size(21, 16);
            this.m_labelRed.TabIndex = 3;
            this.m_labelRed.Text = "&R:";
            this.m_labelRed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_trackBarBlue
            // 
            this.m_trackBarBlue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_trackBarBlue.AutoSize = false;
            this.m_trackBarBlue.LargeChange = 16;
            this.m_trackBarBlue.Location = new System.Drawing.Point(28, 153);
            this.m_trackBarBlue.Maximum = 255;
            this.m_trackBarBlue.Name = "m_trackBarBlue";
            this.m_trackBarBlue.Size = new System.Drawing.Size(265, 20);
            this.m_trackBarBlue.TabIndex = 10;
            this.m_trackBarBlue.TickFrequency = 32;
            this.m_trackBarBlue.Value = 255;
            this.m_trackBarBlue.Scroll += new System.EventHandler(this.m_trackBarBlue_Scroll);
            // 
            // m_trackBarGreen
            // 
            this.m_trackBarGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_trackBarGreen.AutoSize = false;
            this.m_trackBarGreen.LargeChange = 16;
            this.m_trackBarGreen.Location = new System.Drawing.Point(28, 128);
            this.m_trackBarGreen.Maximum = 255;
            this.m_trackBarGreen.Name = "m_trackBarGreen";
            this.m_trackBarGreen.Size = new System.Drawing.Size(265, 20);
            this.m_trackBarGreen.TabIndex = 7;
            this.m_trackBarGreen.TickFrequency = 32;
            this.m_trackBarGreen.Value = 255;
            this.m_trackBarGreen.Scroll += new System.EventHandler(this.m_trackBarGreen_Scroll);
            // 
            // m_trackBarRed
            // 
            this.m_trackBarRed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_trackBarRed.AutoSize = false;
            this.m_trackBarRed.LargeChange = 16;
            this.m_trackBarRed.Location = new System.Drawing.Point(28, 103);
            this.m_trackBarRed.Maximum = 255;
            this.m_trackBarRed.Name = "m_trackBarRed";
            this.m_trackBarRed.Size = new System.Drawing.Size(265, 20);
            this.m_trackBarRed.TabIndex = 4;
            this.m_trackBarRed.TickFrequency = 32;
            this.m_trackBarRed.Value = 255;
            this.m_trackBarRed.Scroll += new System.EventHandler(this.m_trackBarRed_Scroll);
            // 
            // m_textBoxAlpha
            // 
            this.m_textBoxAlpha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_textBoxAlpha.Location = new System.Drawing.Point(302, 73);
            this.m_textBoxAlpha.Maximum = 255;
            this.m_textBoxAlpha.MaxLength = 3;
            this.m_textBoxAlpha.Minimum = 0;
            this.m_textBoxAlpha.Name = "m_textBoxAlpha";
            this.m_textBoxAlpha.Size = new System.Drawing.Size(37, 23);
            this.m_textBoxAlpha.Sizeable = false;
            this.m_textBoxAlpha.TabIndex = 2;
            this.m_textBoxAlpha.Text = "0";
            this.m_textBoxAlpha.Value = 0;
            this.m_textBoxAlpha.TextChanged += new System.EventHandler(this.m_textBoxAlpha_TextChanged);
            // 
            // m_textBoxBlue
            // 
            this.m_textBoxBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_textBoxBlue.Location = new System.Drawing.Point(302, 151);
            this.m_textBoxBlue.Maximum = 255;
            this.m_textBoxBlue.MaxLength = 3;
            this.m_textBoxBlue.Minimum = 0;
            this.m_textBoxBlue.Name = "m_textBoxBlue";
            this.m_textBoxBlue.Size = new System.Drawing.Size(37, 23);
            this.m_textBoxBlue.Sizeable = false;
            this.m_textBoxBlue.TabIndex = 11;
            this.m_textBoxBlue.Text = "0";
            this.m_textBoxBlue.Value = 0;
            this.m_textBoxBlue.TextChanged += new System.EventHandler(this.m_textBoxBlue_TextChanged);
            // 
            // m_textBoxGreen
            // 
            this.m_textBoxGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_textBoxGreen.Location = new System.Drawing.Point(302, 125);
            this.m_textBoxGreen.Maximum = 255;
            this.m_textBoxGreen.MaxLength = 3;
            this.m_textBoxGreen.Minimum = 0;
            this.m_textBoxGreen.Name = "m_textBoxGreen";
            this.m_textBoxGreen.Size = new System.Drawing.Size(37, 23);
            this.m_textBoxGreen.Sizeable = false;
            this.m_textBoxGreen.TabIndex = 8;
            this.m_textBoxGreen.Text = "0";
            this.m_textBoxGreen.Value = 0;
            this.m_textBoxGreen.TextChanged += new System.EventHandler(this.m_textBoxGreen_TextChanged);
            // 
            // m_textBoxRed
            // 
            this.m_textBoxRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_textBoxRed.Location = new System.Drawing.Point(302, 99);
            this.m_textBoxRed.Maximum = 255;
            this.m_textBoxRed.MaxLength = 3;
            this.m_textBoxRed.Minimum = 0;
            this.m_textBoxRed.Name = "m_textBoxRed";
            this.m_textBoxRed.Size = new System.Drawing.Size(37, 23);
            this.m_textBoxRed.Sizeable = false;
            this.m_textBoxRed.TabIndex = 5;
            this.m_textBoxRed.Text = "0";
            this.m_textBoxRed.Value = 0;
            this.m_textBoxRed.TextChanged += new System.EventHandler(this.m_textBoxRed_TextChanged);
            // 
            // m_pictureBoxColorSample
            // 
            this.m_pictureBoxColorSample.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_pictureBoxColorSample.BackColor = System.Drawing.SystemColors.Window;
            this.m_pictureBoxColorSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_pictureBoxColorSample.Location = new System.Drawing.Point(8, 14);
            this.m_pictureBoxColorSample.Name = "m_pictureBoxColorSample";
            this.m_pictureBoxColorSample.SampleColor = System.Drawing.Color.White;
            this.m_pictureBoxColorSample.Size = new System.Drawing.Size(331, 48);
            this.m_pictureBoxColorSample.TabIndex = 25;
            this.m_pictureBoxColorSample.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(11, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Html:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // llblHexColor
            // 
            this.llblHexColor.BackColor = System.Drawing.Color.Transparent;
            this.llblHexColor.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.llblHexColor.Location = new System.Drawing.Point(61, 187);
            this.llblHexColor.Name = "llblHexColor";
            this.llblHexColor.Size = new System.Drawing.Size(124, 20);
            this.llblHexColor.TabIndex = 27;
            this.llblHexColor.Text = "#FFFFFFFF";
            this.llblHexColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustomColorsPanel
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.llblHexColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_labelAlpha);
            this.Controls.Add(this.m_textBoxAlpha);
            this.Controls.Add(this.m_trackBarAlpha);
            this.Controls.Add(this.m_textBoxBlue);
            this.Controls.Add(this.m_textBoxGreen);
            this.Controls.Add(this.m_textBoxRed);
            this.Controls.Add(this.m_labelBlue);
            this.Controls.Add(this.m_labelGreen);
            this.Controls.Add(this.m_labelRed);
            this.Controls.Add(this.m_trackBarBlue);
            this.Controls.Add(this.m_trackBarGreen);
            this.Controls.Add(this.m_trackBarRed);
            this.Controls.Add(this.m_pictureBoxColorSample);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CustomColorsPanel";
            this.Size = new System.Drawing.Size(347, 218);
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxColorSample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Control event handlers

        private void m_trackBarAlpha_Scroll(object sender, System.EventArgs e)
        {
            m_textBoxAlpha.Value = m_trackBarAlpha.Value;
        }

        private void m_trackBarRed_Scroll(object sender, System.EventArgs e)
        {
            m_textBoxRed.Value = m_trackBarRed.Value;
        }

        private void m_trackBarGreen_Scroll(object sender, System.EventArgs e)
        {
            m_textBoxGreen.Value = m_trackBarGreen.Value;
        }

        private void m_trackBarBlue_Scroll(object sender, System.EventArgs e)
        {
            m_textBoxBlue.Value = m_trackBarBlue.Value;
        }

        private void m_textBoxAlpha_TextChanged(object sender, System.EventArgs e)
        {
            m_trackBarAlpha.Value = m_textBoxAlpha.Value;
            SetSampleColor();
        }

        private void m_textBoxRed_TextChanged(object sender, System.EventArgs e)
        {
            m_trackBarRed.Value = m_textBoxRed.Value;
            SetSampleColor();
        }

        private void m_textBoxGreen_TextChanged(object sender, System.EventArgs e)
        {
            m_trackBarGreen.Value = m_textBoxGreen.Value;
            SetSampleColor();
        }

        private void m_textBoxBlue_TextChanged(object sender, System.EventArgs e)
        {
            m_trackBarBlue.Value = m_textBoxBlue.Value;
            SetSampleColor();
        }

        private void SetSampleColor()
        {
            m_pictureBoxColorSample.SampleColor = Color;
            llblHexColor.Text = Color.ToHexColorString();
            OnTrackBarChanged(m_trackBarAlpha.Value, m_trackBarRed.Value, m_trackBarGreen.Value, m_trackBarBlue.Value);
        }

        /// <summary>
        /// Occurs when the value for any of the TrackBars is changed.
        /// </summary>
        /// <param name="Alpha">The currently selected Alpha value.</param>
        /// <param name="Red">The currently selected Red value.</param>
        /// <param name="Green">The currently selected Green value.</param>
        /// <param name="Blue">The currently selected Blue value.</param>
        protected virtual void OnTrackBarChanged(int Alpha, int Red, int Green, int Blue)
        {
            if (this.TrackBarChanged != null)
            {
                this.TrackBarChanged(Alpha, Red, Green, Blue);
            }
        }


        #endregion // Control event handlers

    }
}