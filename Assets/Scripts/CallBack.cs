﻿public delegate void Callback();
public delegate void Callback<T>(T a);
public delegate void Callback<T, U>(T arg1, U arg2);
public delegate void Callback<T, U, V>(T arg1, U arg2, V arg3);

// If Further Callbacks are Added, Following will need updating
/*
    ObserverSystem.cs
*/