﻿// Copyright (c) andy840119 <andy840119@gmail.com>. Licensed under the GPL Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Game.Graphics.Sprites;
using osu.Game.Rulesets.Karaoke.Configuration;
using osu.Game.Screens.Play.PlayerSettings;

namespace osu.Game.Rulesets.Karaoke.UI.PlayerSettings
{
    public class PitchSettings : PlayerSettingsGroup
    {
        protected override string Title => "Pitch";

        private readonly ClickablePlayerSliderBar pitchSliderBar;
        private readonly ClickablePlayerSliderBar vocalPitchSliderBar;
        private readonly ClickablePlayerSliderBar saitenPitchSliderBar;

        public PitchSettings()
        {
            Children = new Drawable[]
            {
                new OsuSpriteText
                {
                    Text = "Pitch:"
                },
                pitchSliderBar = new ClickablePlayerSliderBar(),
                new OsuSpriteText
                {
                    Text = "Vocal pitch:"
                },
                vocalPitchSliderBar = new ClickablePlayerSliderBar(),
                new OsuSpriteText
                {
                    Text = "Saiten pitch:"
                },
                saitenPitchSliderBar = new ClickablePlayerSliderBar()
            };
        }

        [BackgroundDependencyLoader]
        private void load(KaraokeSessionStatics session)
        {
            pitchSliderBar.Bindable = session.GetBindable<int>(KaraokeRulesetSession.Pitch);
            vocalPitchSliderBar.Bindable = session.GetBindable<int>(KaraokeRulesetSession.VocalPitch);
            saitenPitchSliderBar.Bindable = session.GetBindable<int>(KaraokeRulesetSession.SaitenPitch);
        }
    }
}
