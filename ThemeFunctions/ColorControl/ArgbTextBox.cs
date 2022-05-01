using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;


namespace ThemeFunctions
{
	/// <summary>
	/// Numeric TextBox for selecting ARGB (Color: 0 - 255) values.
	/// </summary>
	[ToolboxItem(true)]
	public class ARGBTextBox : System.Windows.Forms.TextBox
	{

		private const int _minAbsolute = 0;
		private const int _maxAbsolute = 255;

		private int _minValue = 0;
		private int _maxValue = 255;

		public ARGBTextBox()
		{
			//
		}

		/// <summary>
		/// Minimum value allowed. Can not be greater than Maximum Value.
		/// </summary>
		[Category("Data")]
		[Description("Indicates the minimum value for the ARGBTextBox text box control.")]
		[Browsable(true)]
		public int Minimum
		{
			get { return _minValue; }
			set
			{
				if (value > _maxValue)
					throw new ArgumentOutOfRangeException("Minimum value cannot be greater than the maximum value.");

				if (value < _minAbsolute)
					throw new ArgumentOutOfRangeException("Minimum value cannot be less than zero.");


				_minValue = value;
			}
		}


		/// <summary>
		/// Maximum value allowed. Can not be less than Minimum Value.
		/// </summary>
		[Category("Data")]
		[Description("Indicates the maximum value for the numeric text box control.")]
		[Browsable(true)]
		public int Maximum
		{
			get
			{
				return _maxValue;
			}
			set
			{
				if (value < _minValue)
					throw new ArgumentOutOfRangeException("Maximum value cannot be less than minimum value.");

				if (value > _maxAbsolute)
					throw new ArgumentOutOfRangeException("Maximum value cannot be greater than 255.");

				_maxValue = value;
			}
		}

		/// <summary>
		/// Value to show in control. Must be in the range between Minimum and Maximum.
		/// </summary>
		[Category("Appearance")]
		[Description("The current value of the numeric text box control.")]
		[Browsable(true)]
		public int Value
		{
			get
			{
				int outval = 0;
				
				if (int.TryParse(base.Text, out outval))
				{
					return outval;
				}
				else
				{
					return 0;
				}
			}
			set
			{
				if (value < Minimum)
					value = Minimum;
				if (value > Maximum)
					value = Maximum;
				base.Text = value.ToString();
			}
		}

		/// <summary>
		/// Gets the value of the control as a string.
		/// </summary>
		[Browsable(false)]
		public new string Text
		{
			get { return base.Text; }
			set {; }
		}


		/// <summary>
		/// 
		/// </summary>
		/// <exclude />
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new string[] Lines
		{
			get { return base.Lines; }
		}


		/// <summary>
		/// 
		/// </summary>
		/// <exclude />
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new System.Windows.Forms.ScrollBars ScrollBars
		{
			get { return base.ScrollBars; }
		}


		/// <inheritdoc cref="System.Windows.Forms.TextBoxBase.OnTextChanged"/>
		protected override void OnTextChanged(EventArgs e)
		{		

			if (Value > Maximum)
			{
				Value = Maximum;
				base.Text = Maximum.ToString();
			}
			else if (Value < Minimum)
			{
				Value = Minimum;
				base.Text = Minimum.ToString();
			}

			base.OnTextChanged(e);
		}

		/// <inheritdoc cref="System.Windows.Forms.Control.OnKeyPress"/>
		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
				e.Handled = false;
			else
				e.Handled = true;
			base.OnKeyPress(e);
		}

		/// <inheritdoc cref="System.Windows.Forms.Control.PreProcessMessage"/>
		public override bool PreProcessMessage(ref Message msg)
		{
			const int WM_KEYDOWN = 0x0100;
			if (msg.Msg == WM_KEYDOWN)
			{
				Keys keyData = ((Keys)(int)msg.WParam) | ModifierKeys;
				Keys keyCode = ((Keys)(int)msg.WParam);

				switch (keyCode)
				{
					case Keys.Up:
						if (Value < this._maxValue) { Value += 1; }
						return true;
					case Keys.Down:
						if (Value > this._minValue) { Value -= 1; }
						return true;
				}
			}
			return base.PreProcessMessage(ref msg);
		}

		/// <inheritdoc cref="System.Windows.Forms.Control.OnLostFocus"/>
		protected override void OnLostFocus(EventArgs e)
		{
			base.Text = Value.ToString();
			base.OnLostFocus(e);
		}

		public bool Sizeable
		{
			get
			{
				return !base.AutoSize;
			}
			set
			{
				base.AutoSize = !value;
			}
		}

	}
}
