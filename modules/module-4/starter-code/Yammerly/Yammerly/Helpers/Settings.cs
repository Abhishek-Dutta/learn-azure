﻿using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace Yammerly.Helpers
{
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants
        private const string LoggedInKey = "logged_in";

        private const string AuthTokenKey = "authToken";
        private static readonly string AuthTokenDefault = string.Empty;

        private const string UserIdKey = "user_id";
        private static readonly string UserIdDefault = string.Empty;

        public const string FirstNameKey = "first_name";
        private static readonly string FirstNameDefault = "Pierce";

        public const string LastNameKey = "last_name";
        private static readonly string LastNameDefault = "Boggan";

        public const string PhotoUrlKey = "photo_url";
        private static readonly string PhotoUrlDefault = "https://secure.gravatar.com/avatar/62921d835f6d165597ff0dcd40fd2664?s=260&d=mm&r=g";
        #endregion

        public static bool IsLoggedIn => !string.IsNullOrWhiteSpace(UserId);
    
        public static string AuthToken
        {
            get
            {
                return AppSettings.GetValueOrDefault<string>(AuthTokenKey, AuthTokenDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<string>(AuthTokenKey, value);
            }
        }

        public static string UserId
        {
            get { return AppSettings.GetValueOrDefault<string>(UserIdKey, UserIdDefault); }
            set { AppSettings.AddOrUpdateValue<string>(UserIdKey, value); }
        }

        public static string FirstName
        {
            get { return AppSettings.GetValueOrDefault<string>(FirstNameKey, FirstNameDefault); }
            set { AppSettings.AddOrUpdateValue<string>(FirstNameKey, value); }
        }

        public static string LastName
        {
            get { return AppSettings.GetValueOrDefault<string>(LastNameKey, LastNameDefault); }
            set { AppSettings.AddOrUpdateValue<string>(LastNameKey, value); }
        }

        public static string PhotoUrl
        {
            get { return AppSettings.GetValueOrDefault<string>(PhotoUrlKey, PhotoUrlDefault); }
            set { AppSettings.AddOrUpdateValue<string>(PhotoUrlKey, value); }
        }
    }
}