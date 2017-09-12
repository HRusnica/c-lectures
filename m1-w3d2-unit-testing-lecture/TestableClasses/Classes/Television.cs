using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestableClasses.Classes
{
    public class Television
    {

        private bool isOn = false;
        private int currentChannel = 3;
        private int currentVolume = 2;

        public bool IsOn
        {
            get { return isOn; }
        }

        public int CurrentChannel
        {
            get { return currentChannel; }
        }

        public int CurrentVolume
        {
            get { return currentVolume; }
        }


        public void TurnOff()
        {
            this.isOn = false;
        }

        public void TurnOn()
        {
            this.isOn = true;
            this.currentChannel = 3;
            this.currentVolume = 2;
        }

        public void ChangeChannel(int newChannel)
        {
            if (this.isOn && (newChannel >= 3 && newChannel <= 18))
            {
                this.currentChannel = newChannel;
            }
        }

        public void ChannelUp()
        {
            if(this.currentChannel >= 3 && this.currentChannel < 18)
            {
                this.currentChannel++;
            }
            else
            {
                this.currentChannel = 3;
            }
        }

        public void ChannelDown()
        {
            if (this.isOn && this.currentChannel > 3)
            {
                this.currentChannel--;
            }
            else if (this.isOn && this.currentChannel == 3)
            {
                this.currentChannel = 18;
            }
        }


        public void RaiseVolume()
        {
            if (this.isOn && this.currentVolume < 10)
            {
                this.currentVolume++;
            }
        }


        public void LowerVolume()
        {
            this.currentChannel--;
        }

    }
}
