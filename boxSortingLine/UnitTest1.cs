using Parcel_sorting_line;
using System;
using System.Collections.Generic;
using Xunit;

namespace boxSortingLine
{
    public class UnitTest1
    {
        [Fact]
        public void When_ParcelHasNewDinemsionAndSortingLineHasNewDinemsion_Then_CanFitSortingLine()
        {
            var BoxSizes = new List<BoxSize>()
            {
                new BoxSize
                {
                    Lenght = 100,
                    Width = 50,
                    SortingLineParam = new List<SortingLineParam>
                    {
                        new SortingLineParam
                        {
                            LineWidth = 60
                        },
                        new SortingLineParam
                        {
                            LineWidth = 80
                        },
                        new SortingLineParam
                        {
                            LineWidth = 90
                        }
                    }
                }
            };
        bool result = Program.FirstParcelLine(BoxSizes);
            Assert.True(result);
        }
    }   
}