using System;


namespace UMAnalyticsHybrid.Binding.iOS
{
    using Foundation;

    [Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern double UMCommonVersionNumber;
        //[Field("UMCommonVersionNumber", "__Internal")]
        //double UMCommonVersionNumber { get; }

        // extern const unsigned char [] UMCommonVersionString;
        //[Field("UMCommonVersionString", "__Internal")]
        //char[] UMCommonVersionString { get; }
    }

    // @interface UMConfigure : NSObject
    [BaseType(typeof(NSObject))]
    interface UMConfigure
    {
        // +(void)initWithAppkey:(NSString *)appKey channel:(NSString *)channel;
        [Static]
        [Export("initWithAppkey:channel:")]
        void InitWithAppkey(string appKey, string channel);

        // +(void)setLogEnabled:(BOOL)bFlag;
        [Static]
        [Export("setLogEnabled:")]
        void SetLogEnabled(bool bFlag);

        // +(void)setEncryptEnabled:(BOOL)value;
        [Static]
        [Export("setEncryptEnabled:")]
        void SetEncryptEnabled(bool value);

        // +(NSString *)umidString;
        [Static]
        [Export("umidString")]
        //[Verify(MethodToProperty)]
        string UmidString { get; }
    }

    // @interface UMCommonModule : NSObject
    [BaseType(typeof(NSObject))]
    interface UMCommonModule
    {
        // +(void)initWithAppkey:(NSString *)appkey channel:(NSString *)channel;
        [Static]
        [Export("initWithAppkey:channel:")]
        void InitWithAppkey(string appkey, string channel);
    }
}
