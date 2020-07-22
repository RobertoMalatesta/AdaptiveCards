//
//  ACRTextInputHandler
//  ACRTextInputHandler.h
//
//  Copyright © 2020 Microsoft. All rights reserved.
//

#import "ACRIBaseInputHandler.h"
#import "ACOBaseCardElement.h"
#import <UIKit/UIKit.h>

@interface ACRTextInputHandler : NSObject<ACRIBaseInputHandler, UITextFieldDelegate>

@property NSPredicate *regexPredicate;
@property NSUInteger maxLength;
@property __weak NSString *text;
@property BOOL hasText;

- (instancetype)init:(ACOBaseCardElement *)acoElem;

@end

@interface ACRNumberInputHandler : ACRTextInputHandler

@property NSInteger min;
@property NSInteger max;

@end

@interface ACRDateInputHandler : ACRTextInputHandler
@end
