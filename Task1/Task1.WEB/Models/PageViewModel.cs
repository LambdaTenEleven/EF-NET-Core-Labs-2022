﻿namespace EducationPortal.Presentation.ViewModels;

public class PageViewModel<T>
{
    public IList<T> Items { get; set; } = new List<T>();

    public int Page { get; set; }

    public int PageSize { get; set; }

    public int PageCount { get; set; }
}