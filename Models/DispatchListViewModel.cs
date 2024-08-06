using System.Collections.Generic;

namespace Webfront.Models
{
    public class DispatchListViewModel
    {
        public List<TblDispatch>? Dispatches { get; set; }
        public PaginationViewModel? Pagination { get; set; }
    }

    public class PaginationViewModel
    {
        public int CurrentPage { get; set; }
        public int TotalItems { get; set; }
        public int PageSize { get; set; }

        public int TotalPages => (int)Math.Ceiling((double)TotalItems / PageSize);
    }
}
