namespace ClassLibrary1.Base;

public class Response
{
    public class PageResult<T>
    {
        //Phân trang ko nhu cầu viết lại nhiều lần nên sài generic đề sài nhiu lần
        public List<T> Items { get; set; } = new List<T>();
        public int TotalItems { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
    }
}