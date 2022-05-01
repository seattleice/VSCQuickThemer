using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace ThemeFunctions
{

	/// <summary>
	/// Summary description for SamplePictureBox.
	/// </summary>
	/// <exclude />
	[ToolboxItem(false)]
	public class SamplePictureBox : System.Windows.Forms.PictureBox
	{

		private Color m_sampleColor;
		private SampleBackground m_backGround;
		private ColorSamplePosition m_samplePosition;

		public SamplePictureBox()
		{
			SampleColor = Color.White;
			Background = SampleBackground.ShadesOfControl;
			SamplePosition = ColorSamplePosition.Middle;
		}

		[Category("Appearance")]
		public Color SampleColor
		{
			get { return m_sampleColor; }
			set
			{
				m_sampleColor = value;
				Invalidate();
			}
		}

		[DefaultValue(SampleBackground.ShadesOfControl)]
		[Category("Appearance")]
		public SampleBackground Background
		{
			get { return m_backGround; }
			set
			{
				m_backGround = value;
				Invalidate();
			}
		}

		[DefaultValue(ColorSamplePosition.Middle)]
		[Category("Appearance")]
		public ColorSamplePosition SamplePosition
		{
			get { return m_samplePosition; }
			set
			{
				m_samplePosition = value;
				Invalidate();
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			FillBackground(e.Graphics);
			DrawSampleColor(e.Graphics);
		}

		private void FillBackground(Graphics graphics)
		{
			switch (Background)
			{
				case SampleBackground.Uniform:
					using (Brush brush = new SolidBrush(BackColor))
					{
						graphics.FillRectangle(brush, ClientRectangle);
					}
					break;
				case SampleBackground.ShadesOfControl:
					graphics.FillRectangle(SystemBrushes.Control, ClientRectangle);
					int widthThird = ClientRectangle.Width / 3;
					Rectangle rect = new Rectangle(ClientRectangle.Location, new Size(widthThird, ClientRectangle.Height));
					graphics.FillRectangle(SystemBrushes.Window, rect);
					rect.Offset(ClientRectangle.Width - widthThird, 0);
					graphics.FillRectangle(SystemBrushes.ControlDark, rect);
					break;
				case SampleBackground.GradientGray:
					using (LinearGradientBrush lgb = new LinearGradientBrush(ClientRectangle, Color.White, Color.Black, 0F))
					{
						graphics.FillRectangle(lgb, ClientRectangle);
					}
					break;
				case SampleBackground.GradientColor:
					using (LinearGradientBrush lgb = new LinearGradientBrush(ClientRectangle, Color.Red, Color.Red, 0F))
					{
						ColorBlend cb = new ColorBlend(4);
						cb.Colors = new Color[] { Color.Red, Color.Yellow, Color.Green, Color.Cyan, Color.Blue, Color.Magenta, Color.Red };
						cb.Positions = new float[] { 0F, 1F / 6, 1F / 3, 1F / 2, 2F / 3, 5F / 6, 1F };
						lgb.InterpolationColors = cb;
						graphics.FillRectangle(lgb, ClientRectangle);
					}
					break;
			}
		}

		private void DrawSampleColor(Graphics graphics)
		{
			Rectangle rect = ClientRectangle;
			switch (SamplePosition)
			{
				case ColorSamplePosition.Entire:
					break;
				case ColorSamplePosition.Top:
					rect.Height = ClientRectangle.Height / 2;
					break;
				case ColorSamplePosition.Middle:
					rect.Y = rect.Height = ClientRectangle.Height / 3;
					break;
				case ColorSamplePosition.Bottom:
					rect.Height = rect.Y = ClientRectangle.Height / 2;
					break;
			}
			using (Brush brush = new SolidBrush(SampleColor))
			{
				graphics.FillRectangle(brush, rect);
			}
		}

	}

}
