using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRouletteAssignment1
{
    class GameSound
    {
        public void shot_sound()
        {
			try
			{
				System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\arina\Documents\VisionCollegeUniWork\ShotWave.wav");
				player.Play();
			} catch (System.IO.FileNotFoundException) { }
        }
        public void load_sound()
        {
			try
			{
				System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\arina\Documents\VisionCollegeUniWork\Gun+Reload.wav");
				player.Play();
			}catch (System.IO.FileNotFoundException) { }
		}
        public void spin_sound()
        {
			try
			{
				System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\arina\Documents\VisionCollegeUniWork\Game Show Wheel Spin-SoundBible.com-1305738466.wav");
				player.Play();
			} catch(System.IO.FileNotFoundException) { }
        }
        public void girl_OhYeah()
        {
			try
			{
				System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\arina\Documents\VisionCollegeUniWork\Oh Yeah Female Voice-SoundBible.com-187589915.wav");
				player.Play();
			} catch (System.IO.FileNotFoundException) { }
        }
        public void girl_scream()
        {
			try
			{
				System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\arina\Documents\VisionCollegeUniWork\Person Screaming No-SoundBible.com-1039481659.wav");
				player.Play();
			} catch (System.IO.FileNotFoundException) { }
        }
        public void background_music()
        {
			try
			{
				System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\arina\Documents\VisionCollegeUniWork\Iron Man 3 [Soundtrack] - 12 - Misfire.wav");
				player.Play();
			} catch (System.IO.FileNotFoundException) { }
        }
        public void background1_music()
        {
			try
			{
				System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\arina1\Documents\VisionCollegeUniWork\Harley Quinn  The Joker - Pretty Little Psycho.wav");
				player.Play();
			} catch (System.IO.FileNotFoundException) { }
        }
    }
}

