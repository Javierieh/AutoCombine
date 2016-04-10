using AutoCombine.Core.Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCombine.Core.Test
{
    public class NestedAutoCombinerTests : DefaultAutoCombinerTests
    {
        public NestedAutoCombinerTests()
        {
            Items = combiner.Combine<NestedValues>().Select(x => x.Values);
        }
    }
}
