using SplashKitSDK;

namespace SplashKitTest
{
    internal static class Program
    {
        public static void Main()
        {
            SoundEffect sndEffect;
            SplashKit.OpenWindow("Sound Demo", 320, 240);

            sndEffect = new SoundEffect("blah", "CA_Beer_Can_Snare_05.flac");
            SplashKit.LoadSoundEffect("beer_can_kick", "CA_Beer_Can_Kick_01.flac");
            SplashKit.LoadSoundEffect("tom", "CA_Beer_Can_Tom_1.flac");
            SplashKit.LoadSoundEffect("snare", "CA_Beer_Can_Snare_01.flac");
            SplashKit.LoadSoundEffect("hat", "CA_Beer_Can_Hat_3.flac");
            SplashKit.LoadSoundEffect("misc", "CA_Beer_Can_Pack_Misc_4.flac");

            do
            {
                SplashKit.ProcessEvents();
                if (SplashKit.KeyDown(KeyCode.RightCtrlKey) || SplashKit.KeyDown(KeyCode.LeftCtrlKey))
                {
                    if (SplashKit.KeyTyped(KeyCode.Num1Key))
                        sndEffect = SplashKit.SoundEffectNamed("blah");
                    if (SplashKit.KeyTyped(KeyCode.Num2Key))
                        sndEffect = SplashKit.SoundEffectNamed("beer_can_kick");
                    if (SplashKit.KeyTyped(KeyCode.Num3Key))
                        sndEffect = SplashKit.SoundEffectNamed("tom");
                    if (SplashKit.KeyTyped(KeyCode.Num4Key))
                        sndEffect = SplashKit.SoundEffectNamed("snare");
                    if (SplashKit.KeyTyped(KeyCode.Num5Key))
                        sndEffect = SplashKit.SoundEffectNamed("hat");
                    if (SplashKit.KeyTyped(KeyCode.Num6Key))
                        sndEffect = SplashKit.SoundEffectNamed("misc");
                }
                else
                {
                    if (SplashKit.KeyTyped(KeyCode.Num1Key))
                        sndEffect.Play();
                    if (SplashKit.KeyTyped(KeyCode.Num2Key))
                        sndEffect.Play(0.5f);
                    if (SplashKit.KeyTyped(KeyCode.Num3Key))
                        sndEffect.Play(3, 0.25f);
                    if (SplashKit.KeyTyped(KeyCode.Num4Key))
                        sndEffect.Play(-1, 0.1f);
                    if (SplashKit.KeyTyped(KeyCode.Num5Key))
                        if (sndEffect.IsPlaying)
                            sndEffect.Stop();
                }

                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawText("Control Sound (Escape or q to quit)", Color.Red, "arial", 18, 15, 15);
                SplashKit.DrawText("1: Play Sound At Full Volume", Color.Blue, "arial", 14, 20, 50);
                SplashKit.DrawText("2: Play Sound At 50% Volume", Color.Blue, "arial", 14, 20, 80);
                SplashKit.DrawText("3: Play Sound At 25% Volume 3 Times", Color.Blue, "arial", 14, 20, 110);
                SplashKit.DrawText("4: Play Sound Continuously at 10%", Color.Blue, "arial", 14, 20, 140);
                SplashKit.DrawText("5: Stop Playing Current Sound", Color.Blue, "arial", 14, 20, 170);
                SplashKit.DrawText("CTRL + (1-6) switch sound effects", Color.Blue, "arial", 14, 20, 200);

                SplashKit.RefreshScreen(60);
            } while (!(SplashKit.QuitRequested() || SplashKit.KeyTyped(KeyCode.EscapeKey) ||
                       SplashKit.KeyTyped(KeyCode.QKey)));
        }
    }
}