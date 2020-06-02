/* 
*   NatShare
*   Copyright (c) 2020 Yusuf Olokoba.
*/

namespace NatSuite.Sharing {

    using UnityEngine;
    using System.Threading.Tasks;
    using Internal;

    /// <summary>
    /// A payload for saving to the camera roll.
    /// </summary>
    public sealed class SavePayload : ISharePayload {

        #region --Client API--
        /// <summary>
        /// Create a save payload.
        /// </summary>
        /// <param name="album">Optional. Album name in which contents should be saved.</param>
        public SavePayload (string album = default) => this.payload = new NativePayload((callback, context) => Bridge.CreateSavePayload(album, callback, context));

        /// <summary>
        /// Nop. No concept as saving text to the gallery.
        /// </summary>
        public ISharePayload AddText (string text) {
            payload.AddText(text);
            return this;
        }

        /// <summary>
        /// Add an image to the payload.
        /// Note that the image MUST be readable.
        /// </summary>
        /// <param name="image">Image to be added to the gallery.</param>
        public ISharePayload AddImage (Texture2D image) {
            payload.AddImage(image);
            return this;
        }

        /// <summary>
        /// Add media to the payload.
        /// </summary>
        /// <param name="path">Path to local media file to be added to the gallery.</param>
        public ISharePayload AddMedia (string path) {
            payload.AddMedia(path);
            return this;
        }

        /// <summary>
        /// Commit the payload and return whether payload was successfully shared.
        /// </summary>
        public Task<bool> Commit () => payload.Commit();
        #endregion

        private readonly ISharePayload payload;
    }
}