using PnP.Core.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PnP.Core.Model.SharePoint
{
    /// <summary>
    /// Public interface to define a collection of Folder objects
    /// </summary>
    [ConcreteType(typeof(FolderCollection))]
    public interface IFolderCollection : IQueryable<IFolder>, IAsyncEnumerable<IFolder>, IDataModelCollection<IFolder>, IDataModelCollectionLoad<IFolder>, IDataModelCollectionDeleteByGuidId, ISupportModules<IFolderCollection>
    {
        #region Add

        /// <summary>
        /// Add a folder
        /// </summary>
        /// <param name="name">The name of the folder to add</param>
        /// <returns>The newly added folder</returns>
        Task<IFolder> AddBatchAsync(string name);

        /// <summary>
        /// Add a folder
        /// </summary>
        /// <param name="name">The name of the folder to add</param>
        /// <returns>The newly added folder</returns>
        IFolder AddBatch(string name);

        /// <summary>
        /// Add a folder using a specific batch instance
        /// </summary>
        /// <param name="batch">The batch instance to use</param>
        /// <param name="name">The name of the folder to add</param>
        /// <returns>The newly added folder</returns>
        Task<IFolder> AddBatchAsync(Batch batch, string name);

        /// <summary>
        /// Add a folder using a specific batch instance
        /// </summary>
        /// <param name="batch">The batch instance to use</param>
        /// <param name="name">The name of the folder to add</param>
        /// <returns>The newly added folder</returns>
        IFolder AddBatch(Batch batch, string name);

        /// <summary>
        /// Add a folder
        /// </summary>
        /// <param name="name">The name of the folder to add</param>
        /// <returns>The newly added folder</returns>
        Task<IFolder> AddAsync(string name);

        /// <summary>
        /// Add a folder
        /// </summary>
        /// <param name="name">The name of the folder to add</param>
        /// <returns>The newly added folder</returns>
        IFolder Add(string name);

        #endregion
    }
}