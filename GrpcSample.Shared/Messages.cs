#nullable enable

using System.Collections.Generic;
using Bond;

namespace GrpcSample.Shared
{
    [Schema]
    public class CustomRequest
    {
        [Id(0)]
        public int Payload { get; set; }
        
        [Id(1)]
        public int? NullablePayload { get; set; }

        [Id(2)]
        public List<int>? NullableCollection { get; set; }

        [Id(3)] public string Text { get; set; } = string.Empty;
    }

    [Schema]
    public class CustomResponse
    {
        [Id(0)]
        public int Payload { get; set; }
        
        [Id(1)]
        public int? NullablePayload { get; set; }

        [Id(2)]
        public List<int>? NullableCollection { get; set; }

        [Id(3)] public string Text { get; set; } = string.Empty;
    }
}