using System;

namespace OO_Plus_Events
{
	public class CountManager
	{
		private int _count;
		public delegate void SeventyPercentHandler(object sender, EventArgs e);
		public event SeventyPercentHandler SeventyPercentEvent;
		public delegate void OneHundredPercentHandler(object sender, EventArgs e);
		public event OneHundredPercentHandler OneHundredPercentEvent;

		public CountManager()
		{
			_count = 0;
		}

		public int Count()
		{
			_count += 10;

			switch(_count)
			{
				case 70: OnReach70Percent(new EventArgs()); break;
				case 100: OnReach100Percent(new EventArgs()); break;
				case 110: _count -= 10; break;
			}

			return _count;
		}

		protected virtual void OnReach70Percent(EventArgs e)
		{
			SeventyPercentEvent?.Invoke(this, e);
		}

		protected virtual void OnReach100Percent(EventArgs e)
		{
			OneHundredPercentEvent?.Invoke(this, e);
		}
	}
}
