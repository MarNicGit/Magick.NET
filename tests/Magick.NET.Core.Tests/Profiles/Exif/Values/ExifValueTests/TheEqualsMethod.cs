﻿// Copyright 2013-2020 Dirk Lemstra <https://github.com/dlemstra/Magick.NET/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   https://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied. See the License for the specific language governing permissions
// and limitations under the License.

using ImageMagick;
using Xunit;

namespace Magick.NET.Core.Tests
{
    public partial class ExifValueTests
    {
        public class TheEqualsMethod
        {
            [Fact]
            public void ShouldReturnFalseWhenInstanceIsNull()
            {
                var value = new ExifLong(ExifTag.SubIFDOffset);

                Assert.False(value.Equals(null));
            }

            [Fact]
            public void ShouldReturnTrueWhenInstanceIsTheSame()
            {
                var value = new ExifLong(ExifTag.SubIFDOffset);

                Assert.True(value.Equals(value));
            }

            [Fact]
            public void ShouldReturnTrueWhenObjectIsTheSame()
            {
                var value = new ExifLong(ExifTag.SubIFDOffset);

                Assert.True(value.Equals(value));
            }

            [Fact]
            public void ShouldReturnTrueWhenInstanceIsEqual()
            {
                var first = new ExifLong(ExifTag.SubIFDOffset);
                var second = ExifTag.SubIFDOffset;

                Assert.True(first.Equals(second));
            }

            [Fact]
            public void ShouldReturnTrueWhenObjectIsEqual()
            {
                var first = new ExifLong(ExifTag.SubIFDOffset);
                var second = new ExifLong(ExifTag.SubIFDOffset);

                Assert.True(first.Equals(second));
            }

            [Fact]
            public void ShouldReturnFalseWhenInstanceIsNotEqual()
            {
                var first = new ExifLong(ExifTag.SubIFDOffset);
                var second = ExifTag.CodingMethods;

                Assert.False(first.Equals(second));
            }

            [Fact]
            public void ShouldReturnFalseWhenObjectIsNotEqual()
            {
                var first = new ExifLong(ExifTag.SubIFDOffset);
                var second = new ExifLong(ExifTag.CodingMethods);

                Assert.False(first.Equals(second));
            }
        }
    }
}
