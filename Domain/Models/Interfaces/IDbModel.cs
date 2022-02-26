namespace StretchCeilings.Domain.Models.Interfaces
{
    /// <summary>
    /// Represents a database entity
    /// </summary>
    public interface IDbModel
    {
        /// <summary>
        /// Add entity to a database
        /// </summary>
        void Add();
        /// <summary>
        /// Update entity in a database
        /// </summary>
        void Update();
        /// <summary>
        /// Delete entity from a database
        /// </summary>
        void Delete();
    }
}