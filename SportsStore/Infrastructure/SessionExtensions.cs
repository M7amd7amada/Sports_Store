// Copyright (c) 2023 Mohammed Hamada, GitHub: M7amd7amada.
// Licensed under MIT license. See LICENSE file in the project root for license information.

using System.Text.Json;

namespace SportsStore.Infrastructure;

public static class SessionExtensions
{

    public static void SetJson(this ISession session, string key, object value)
    {
        session.SetString(key, JsonSerializer.Serialize(value));
    }

    public static T? GetJson<T>(this ISession session, string key)
    {
        var sessionData = session.GetString(key);
        return sessionData == null
            ? default(T) : JsonSerializer.Deserialize<T>(sessionData);
    }
}
