/*
 * Author: Kishore Reddy
 * Url: http://commonlibrarynet.codeplex.com/
 * Title: CommonLibrary.NET
 * Copyright: � 2009 Kishore Reddy
 * License: LGPL License
 * LicenseUrl: http://commonlibrarynet.codeplex.com/license
 * Description: A C# based .NET 3.5 Open-Source collection of reusable components.
 * Usage: Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Text;
using ComLib.Entities;


namespace ComLib.Modules
{
    /// <summary>
    /// Base class used for module settings.
    /// </summary>
    public interface IModuleDao : IRepository<Module>
    {
        /// <summary>
        /// Dictionary of all the module definitions.
        /// </summary>
        IDictionary<string, ModuleDefinition> Definitions { get; }


        /// <summary>
        /// Dictionary of all the modules.
        /// </summary>
        IDictionary<string, Module> Modules { get; }
    }    
}
