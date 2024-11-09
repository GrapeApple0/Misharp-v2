using System.Net;

namespace Misharp
{
    public class Response<T> where T : class
    {
        private T? _data { get; }
        public T Result
        {
            get
            {
                if (this._data == null) throw new NullReferenceException();
                return this._data;
            }
        }
        
        public HttpStatusCode StatusCode { get; }
        public Response(HttpStatusCode statusCode, T? data = null)
        {
            this._data = data;
            this.StatusCode = statusCode;
        }

        public bool IsNull()
        {
            return this._data == null;
        }
    }

    public class EmptyResponse { }
}
