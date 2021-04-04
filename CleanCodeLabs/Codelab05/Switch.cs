using System.Drawing;

namespace CleanCodeLabs.Codelab05
{
    /// <summary>
    ///     A Switch to Turn something (in this case: a Lamp) ON or OFF
    /// </summary>
    internal class Switch
    {
        public ISwitchable switchable;
        public bool IsSwitchOn { get; private set; }
        public void Toggle()
        {
            IsSwitchOn = !IsSwitchOn;
            if (IsSwitchOn)
            {
               switchable.TurnOn();
            }
            else
            {
                switchable.TurnOff();
            }
        }
    }
}