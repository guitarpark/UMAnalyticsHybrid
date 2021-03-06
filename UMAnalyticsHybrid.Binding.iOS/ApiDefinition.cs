﻿using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using WebKit;
using CoreLocation;

namespace UMAnalyticsHybrid.Binding.iOS
{
    // @interface DplusMobClick : NSObject
    [BaseType(typeof(NSObject))]
    interface DplusMobClick
    {
        // +(void)track:(NSString *)eventName;
        [Static]
        [Export("track:")]
        void Track(string eventName);

        // +(void)track:(NSString *)eventName property:(NSDictionary *)property;
        [Static]
        [Export("track:property:")]
        void Track(string eventName, NSDictionary property);

        // +(void)registerSuperProperty:(NSDictionary *)property;
        [Static]
        [Export("registerSuperProperty:")]
        void RegisterSuperProperty(NSDictionary property);

        // +(void)unregisterSuperProperty:(NSString *)propertyName;
        [Static]
        [Export("unregisterSuperProperty:")]
        void UnregisterSuperProperty(string propertyName);

        // +(NSString *)getSuperProperty:(NSString *)propertyName;
        [Static]
        [Export("getSuperProperty:")]
        string GetSuperProperty(string propertyName);

        // +(NSDictionary *)getSuperProperties;
        [Static]
        [Export("getSuperProperties")]
        //[Verify(MethodToProperty)]
        NSDictionary SuperProperties { get; }

        // +(void)clearSuperProperties;
        [Static]
        [Export("clearSuperProperties")]
        void ClearSuperProperties();

        // +(void)registerPreProperties:(NSDictionary *)property;
        [Static]
        [Export("registerPreProperties:")]
        void RegisterPreProperties(NSDictionary property);

        // +(void)unregisterPreProperty:(NSString *)propertyName;
        [Static]
        [Export("unregisterPreProperty:")]
        void UnregisterPreProperty(string propertyName);

        // +(NSDictionary *)getPreProperties;
        [Static]
        [Export("getPreProperties")]
        //[Verify(MethodToProperty)]
        NSDictionary PreProperties { get; }

        // +(void)clearPreProperties;
        [Static]
        [Export("clearPreProperties")]
        void ClearPreProperties();

        // +(void)setFirstLaunchEvent:(NSArray *)eventList;
        [Static]
        [Export("setFirstLaunchEvent:")]
        //[Verify(StronglyTypedNSArray)]
        void SetFirstLaunchEvent(NSObject[] eventList);
    }

    // typedef void (^CallbackBlock)();
    delegate void CallbackBlock();

    // @interface MobClick : NSObject <UIAlertViewDelegate>
    [BaseType(typeof(NSObject))]
    interface MobClick : IUIAlertViewDelegate
    {
        // +(void)setScenarioType:(eScenarioType)eSType;
        [Static]
        [Export("setScenarioType:")]
        void SetScenarioType(eScenarioType eSType);

        // +(void)setCrashReportEnabled:(BOOL)value;
        [Static]
        [Export("setCrashReportEnabled:")]
        void SetCrashReportEnabled(bool value);

        // +(void)logPageView:(NSString *)pageName seconds:(int)seconds;
        [Static]
        [Export("logPageView:seconds:")]
        void LogPageView(string pageName, int seconds);

        // +(void)beginLogPageView:(NSString *)pageName;
        [Static]
        [Export("beginLogPageView:")]
        void BeginLogPageView(string pageName);

        // +(void)endLogPageView:(NSString *)pageName;
        [Static]
        [Export("endLogPageView:")]
        void EndLogPageView(string pageName);

        // +(void)event:(NSString *)eventId;
        [Static]
        [Export("event:")]
        void Event(string eventId);

        // +(void)event:(NSString *)eventId label:(NSString *)label;
        [Static]
        [Export("event:label:")]
        void Event(string eventId, string label);

        // +(void)event:(NSString *)eventId attributes:(NSDictionary *)attributes;
        [Static]
        [Export("event:attributes:")]
        void Event(string eventId, NSDictionary attributes);

        // +(void)event:(NSString *)eventId attributes:(NSDictionary *)attributes counter:(int)number;
        [Static]
        [Export("event:attributes:counter:")]
        void Event(string eventId, NSDictionary attributes, int number);

        // +(void)beginEvent:(NSString *)eventId;
        [Static]
        [Export("beginEvent:")]
        void BeginEvent(string eventId);

        // +(void)endEvent:(NSString *)eventId;
        [Static]
        [Export("endEvent:")]
        void EndEvent(string eventId);

        // +(void)beginEvent:(NSString *)eventId label:(NSString *)label;
        [Static]
        [Export("beginEvent:label:")]
        void BeginEvent(string eventId, string label);

        // +(void)endEvent:(NSString *)eventId label:(NSString *)label;
        [Static]
        [Export("endEvent:label:")]
        void EndEvent(string eventId, string label);

        // +(void)beginEvent:(NSString *)eventId primarykey:(NSString *)keyName attributes:(NSDictionary *)attributes;
        [Static]
        [Export("beginEvent:primarykey:attributes:")]
        void BeginEvent(string eventId, string keyName, NSDictionary attributes);

        // +(void)endEvent:(NSString *)eventId primarykey:(NSString *)keyName;
        [Static]
        [Export("endEvent:primarykey:")]
        void EndEventPrimarykey(string eventId, string keyName);

        // +(void)event:(NSString *)eventId durations:(int)millisecond;
        [Static]
        [Export("event:durations:")]
        void Event(string eventId, int millisecond);

        // +(void)event:(NSString *)eventId label:(NSString *)label durations:(int)millisecond;
        [Static]
        [Export("event:label:durations:")]
        void Event(string eventId, string label, int millisecond);

        // +(void)event:(NSString *)eventId attributes:(NSDictionary *)attributes durations:(int)millisecond;
        [Static]
        [Export("event:attributes:durations:")]
        void EventAttributes(string eventId, NSDictionary attributes, int millisecond);

        // +(void)profileSignInWithPUID:(NSString *)puid;
        [Static]
        [Export("profileSignInWithPUID:")]
        void ProfileSignInWithPUID(string puid);

        // +(void)profileSignInWithPUID:(NSString *)puid provider:(NSString *)provider;
        [Static]
        [Export("profileSignInWithPUID:provider:")]
        void ProfileSignInWithPUID(string puid, string provider);

        // +(void)profileSignOff;
        [Static]
        [Export("profileSignOff")]
        void ProfileSignOff();

        // +(void)setLatitude:(double)latitude longitude:(double)longitude;
        [Static]
        [Export("setLatitude:longitude:")]
        void SetLatitude(double latitude, double longitude);

        // +(void)setLocation:(CLLocation *)location;
        [Static]
        [Export("setLocation:")]
        void SetLocation(CLLocation location);

        // +(BOOL)isJailbroken;
        [Static]
        [Export("isJailbroken")]
        //[Verify(MethodToProperty)]
        bool IsJailbroken { get; }

        // +(BOOL)isPirated;
        [Static]
        [Export("isPirated")]
        //[Verify(MethodToProperty)]
        bool IsPirated { get; }

        // +(void)setSecret:(NSString *)secret;
        [Static]
        [Export("setSecret:")]
        void SetSecret(string secret);

        // +(void)setCrashCBBlock:(CallbackBlock)cbBlock;
        [Static]
        [Export("setCrashCBBlock:")]
        void SetCrashCBBlock(CallbackBlock cbBlock);
    }

    // @interface MobClickGameAnalytics : NSObject
    [BaseType(typeof(NSObject))]
    interface MobClickGameAnalytics
    {
        // +(void)profileSignInWithPUID:(NSString *)puid;
        [Static]
        [Export("profileSignInWithPUID:")]
        void ProfileSignInWithPUID(string puid);

        // +(void)profileSignInWithPUID:(NSString *)puid provider:(NSString *)provider;
        [Static]
        [Export("profileSignInWithPUID:provider:")]
        void ProfileSignInWithPUID(string puid, string provider);

        // +(void)profileSignOff;
        [Static]
        [Export("profileSignOff")]
        void ProfileSignOff();

        // +(void)setUserLevelId:(int)level;
        [Static]
        [Export("setUserLevelId:")]
        void SetUserLevelId(int level);

        // +(void)startLevel:(NSString *)level;
        [Static]
        [Export("startLevel:")]
        void StartLevel(string level);

        // +(void)finishLevel:(NSString *)level;
        [Static]
        [Export("finishLevel:")]
        void FinishLevel(string level);

        // +(void)failLevel:(NSString *)level;
        [Static]
        [Export("failLevel:")]
        void FailLevel(string level);

        // +(void)exchange:(NSString *)orderId currencyAmount:(double)currencyAmount currencyType:(NSString *)currencyType virtualCurrencyAmount:(double)virtualAmount paychannel:(int)channel;
        [Static]
        [Export("exchange:currencyAmount:currencyType:virtualCurrencyAmount:paychannel:")]
        void Exchange(string orderId, double currencyAmount, string currencyType, double virtualAmount, int channel);

        // +(void)pay:(double)cash source:(int)source coin:(double)coin;
        [Static]
        [Export("pay:source:coin:")]
        void Pay(double cash, int source, double coin);

        // +(void)pay:(double)cash source:(int)source item:(NSString *)item amount:(int)amount price:(double)price;
        [Static]
        [Export("pay:source:item:amount:price:")]
        void Pay(double cash, int source, string item, int amount, double price);

        // +(void)buy:(NSString *)item amount:(int)amount price:(double)price;
        [Static]
        [Export("buy:amount:price:")]
        void Buy(string item, int amount, double price);

        // +(void)use:(NSString *)item amount:(int)amount price:(double)price;
        [Static]
        [Export("use:amount:price:")]
        void Use(string item, int amount, double price);

        // +(void)bonus:(double)coin source:(int)source;
        [Static]
        [Export("bonus:source:")]
        void Bonus(double coin, int source);

        // +(void)bonus:(NSString *)item amount:(int)amount price:(double)price source:(int)source;
        [Static]
        [Export("bonus:amount:price:source:")]
        void Bonus(string item, int amount, double price, int source);

        // +(void)setUserLevel:(NSString *)level;
        [Static]
        [Export("setUserLevel:")]
        void SetUserLevel(string level);

        // +(void)setUserID:(NSString *)userId sex:(int)sex age:(int)age platform:(NSString *)platform;
        [Static]
        [Export("setUserID:sex:age:platform:")]
        void SetUserID(string userId, int sex, int age, string platform);
    }

    // @interface UMAnalyticsModule : NSObject
    [BaseType(typeof(NSObject))]
    interface UMAnalyticsModule
    {
        // +(BOOL)execute:(NSString *)parameters webView:(WKWebView *)webView;
        [Static]
        [Export("execute:webView:")]
        bool Execute(string parameters, WKWebView webView);
    }

}
