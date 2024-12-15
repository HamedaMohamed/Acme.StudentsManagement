﻿using Microsoft.Extensions.Localization;
using Acme.StudentsManagement.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.StudentsManagement;

[Dependency(ReplaceServices = true)]
public class StudentsManagementBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<StudentsManagementResource> _localizer;

    public StudentsManagementBrandingProvider(IStringLocalizer<StudentsManagementResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}