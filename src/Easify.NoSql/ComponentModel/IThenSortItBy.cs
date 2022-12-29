// This software is part of the LittleBlocks.Ef Library
// Copyright (C) 2018 LittleBlocks
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 


using System;
using System.Linq.Expressions;

namespace LittleBlocks.NoSql.ComponentModel
{
    public interface IThenSortItBy<T>
    {
        IThenSortItBy<T> ThenBy(string field);
        IThenSortItBy<T> ThenByDescending(string field);
        IThenSortItBy<T> ThenBy(Expression<Func<T, object>> property);
        IThenSortItBy<T> ThenByDescending(Expression<Func<T, object>> property);
    }
}