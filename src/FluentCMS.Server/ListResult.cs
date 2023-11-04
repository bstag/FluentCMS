﻿namespace FluentCMS.Server;

public interface IListResult<TData> : IResult<IEnumerable<TData>>
{
    public int PageSize { get; }
    public int TotalPages { get; }
    public int PageNumber { get; }
    public long TotalCount { get; }
    public bool HasPrevious { get; }
    public bool HasNext { get; }
}

public class ListResult<TData> : Result<IEnumerable<TData>>, IListResult<TData>
{
    public int PageSize { get; }
    public int TotalPages { get; }
    public int PageNumber { get; }
    public long TotalCount { get; }
    public bool HasPrevious { get; }
    public bool HasNext { get; }

    //public ListResult(IEnumerable<TData> data, int pageNumber, int pageSize, long totalCount)
    //{
    //    Data = data;
    //    PageNumber = pageNumber;
    //    PageSize = pageSize;
    //    TotalCount = totalCount;
    //    TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
    //    HasPrevious = PageNumber > 1;
    //    HasNext = PageNumber < TotalPages;
    //}

    //public ListResult(IEnumerable<TData> data, int pageNumber, int pageSize, long totalCount, int totalPages, bool hasPrevious, bool hasNext)
    //{
    //    Data = data;
    //    PageNumber = pageNumber;
    //    PageSize = pageSize;
    //    TotalCount = totalCount;
    //    TotalPages = totalPages;
    //    HasPrevious = hasPrevious;
    //    HasNext = hasNext;
    //}

    public ListResult(IEnumerable<TData> data)
    {
        Data = data;
        PageNumber = 1;
        PageSize = 1;
        TotalCount = data.Count();
        TotalPages = 1;
        HasPrevious = false;
        HasNext = false;
    }
}