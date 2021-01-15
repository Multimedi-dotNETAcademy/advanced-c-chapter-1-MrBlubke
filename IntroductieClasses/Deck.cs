using System;
using System.Collections.Generic;
using System.Text;

namespace IntroductieClasses
{
    class Deck
        {
        public int deckNr;
        public double pitchSlider;
        public string trackTitle;
        public string trackArtist;
        public double trackBPM;
        public enum playState { stopped, paused, playing};
        public double bass, mid, treble;
        public TimeSpan trackDuration;
        public int trackVolume;
        //public TimeSpan TrackPointer; public class mp3Tag : Deck
        //{
        //    public string Artist, Title, Album;
        //    public int year, bpm;
        //    public TimeSpan duration;
        //}
    }
  

}
