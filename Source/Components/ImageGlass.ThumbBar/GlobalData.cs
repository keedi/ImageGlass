﻿/*
ImageGlass Project - Image viewer for Windows
Copyright (C) 2014 DUONG DIEU PHAP
Project homepage: http://imageglass.org

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.Drawing;
using System.Windows.Forms;


namespace ImageGlass.ThumbBar
{
    /// <summary>
    /// Global data class of the application.
    /// </summary>
    static class GlobalData
    {

        /// <summary>
        /// The given thumbnail width and height
        /// </summary>
        public static int ThumbnailWidthAndHeight = 64;

        /// <summary>
        /// The given thumbnail size in MB
        /// </summary>
        public static int ThumbnailMaxLoadingSize = 5;

        /// <summary>
        /// The invalid image logo.
        /// </summary>
        public static Image InvalidImage = null;

        /// <summary>
        /// The thumbnail of the invalid image logo.
        /// </summary>
        public static Image InvalidImageThumbnail = null;

        /// <summary>
        /// The thumbnail of the too large image logo.
        /// </summary>
        public static Image TooLargeImageThumbnail = null;

        /// <summary>
        /// The loading image logo.
        /// </summary>
        public static Image LoadingImage = null;

        /// <summary>
        /// The thumbnail of the loading image logo.
        /// </summary>
        public static Image LoadingImageThumbnail = null;

        /// <summary>
        /// Static constructor.
        /// </summary>
        static GlobalData()
        {
            InvalidImage = new Bitmap(ThumbnailWidthAndHeight, ThumbnailWidthAndHeight);
            InvalidImageThumbnail = new Bitmap(ThumbnailWidthAndHeight, ThumbnailWidthAndHeight);
            TooLargeImageThumbnail = new Bitmap(ThumbnailWidthAndHeight, ThumbnailWidthAndHeight);

            LoadingImage = new Bitmap(ThumbnailWidthAndHeight, ThumbnailWidthAndHeight);
            LoadingImageThumbnail = new Bitmap(ThumbnailWidthAndHeight, ThumbnailWidthAndHeight);
        }

        /// <summary>
        /// Reload all data
        /// </summary>
        public static void ReloadData()
        {
            //InvalidImage = new Bitmap(ThumbnailWidthAndHeight, ThumbnailWidthAndHeight);
            //InvalidImageThumbnail = new Bitmap(ThumbnailWidthAndHeight, ThumbnailWidthAndHeight);
            //TooLargeImageThumbnail = new Bitmap(ThumbnailWidthAndHeight, ThumbnailWidthAndHeight);

            //LoadingImage = new Bitmap(ThumbnailWidthAndHeight, ThumbnailWidthAndHeight);
            //LoadingImageThumbnail = new Bitmap(ThumbnailWidthAndHeight, ThumbnailWidthAndHeight);
        }

    }

}
