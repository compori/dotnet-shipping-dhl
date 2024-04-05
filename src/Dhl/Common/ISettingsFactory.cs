namespace Compori.Shipping.Dhl.Common
{
    public interface ISettingsFactory<TSettings> where TSettings : Settings
    {
        /// <summary>
        /// Creates the settings for using the dhl api client properly.
        /// </summary>
        /// <returns>TSettings.</returns>
        TSettings Create();
    }
}
