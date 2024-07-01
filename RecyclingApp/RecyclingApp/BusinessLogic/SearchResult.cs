using System.Collections.Generic;

namespace RecyclingApp.BusinessLogic;

public class SearchResult<T>
{
    public List<T> Items { get; set; }

    public int TotalPages { get; set; }
}