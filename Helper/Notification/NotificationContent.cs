// <copyright file="NotificationContent.cs" company="MaaAssistantArknights">
// MaaWpfGui - A part of the MaaCoreArknights project
// Copyright (C) 2021 MistEO and Contributors
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License v3.0 only as published by
// the Free Software Foundation, either version 3 of the License, or
// any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY
// </copyright>

using System.Collections.Generic;

namespace MFAWPF.Helper.Notification;

internal class NotificationContent
{
    public string Summary { get; set; }

    public string Body { get; set; }

    private readonly List<NotificationAction> _actions = [];

    public IList<NotificationAction> Actions => _actions;

    private readonly List<NotificationHint> _hints = [];

    public IList<NotificationHint> Hints => _hints;
}
