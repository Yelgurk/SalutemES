﻿using OneOf;
using System.Security.Authentication;

namespace SalutemES.Engineer.Infrastructure.DataBase;

[GenerateOneOf]
public sealed partial class DataBaseApiOr<T> : OneOfBase<DataBaseApi, T>
{
    public bool IsSuccess => this.IsT0;
    public bool IsError => this.IsT1;

    public DataBaseApi Api => this.AsT0;
    public T Exception => this.AsT1;
}

[GenerateOneOf]
public sealed partial class BoolResponseOr<T> : OneOfBase<bool, T>
{
    public bool IsSuccess => this.IsT0;
    public bool IsError => this.IsT1;

    public bool Result => this.AsT0;
    public T Exception => this.AsT1;
}

public record SQLUnavailable(string message = "Cant connect to SQL server, check connection string");

public record SQLExecError(string message = "Cant execute command, check arguments");

public record SQLCommandNotReady(string message = "Cant prepare command for execution, check arguments");