﻿/* Copyright © 2019 Lee Kelleher.
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System.Collections.Generic;
using Umbraco.Core.IO;
using Umbraco.Core.PropertyEditors;

namespace Umbraco.Community.Contentment.DataEditors
{
    internal sealed class RenderMacroConfigurationEditor : ConfigurationEditor
    {
        internal const string Macro = "macro";

        public RenderMacroConfigurationEditor()
            : base()
        {
            Fields.Add(new ConfigurationField
            {
                Key = Macro,
                Name = nameof(Macro),
                Description = "Select and configure the macro to be displayed.",
                View = IOHelper.ResolveUrl(MacroPickerDataEditor.DataEditorViewPath),
                Config = new Dictionary<string, object>
                {
                    { MaxItemsConfigurationField.MaxItems, 1 }
                }
            });

            Fields.Add(new HideLabelConfigurationField());
        }
    }
}
