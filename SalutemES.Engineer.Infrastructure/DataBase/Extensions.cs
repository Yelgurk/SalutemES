﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalutemES.Engineer.Infrastructure.DataBase;

public static class Extensions
{
    public static T? Cast<T>(this object obj) where T : class => obj as T;

    public static T? Do<T>(this T obj, Predicate<T> action) => action(obj) ? obj : default(T?);

    public static T? Handler<T>(this T obj, Predicate<T> mainAction, Action<T>? errorAction = null) => mainAction(obj) ? obj : ErrorActionHandler<T>(errorAction, obj);

    private static T? ErrorActionHandler<T>(Action<T>? errorAction, T obj)
    {
        errorAction?.Invoke(obj);
        return default(T?);
    }
}