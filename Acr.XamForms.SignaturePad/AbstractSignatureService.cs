﻿using System;
using Xamarin.Forms;


namespace Acr.XamForms.SignaturePad {

    public abstract class AbstractSignatureService : ISignatureService {
        public SignaturePadConfiguration Configuration { get; private set; }

        protected AbstractSignatureService() {
            this.Configuration = new SignaturePadConfiguration {
                ImageType = ImageFormatType.Png,
                MainBackgroundColor = Color.FromHex("#696969"),
                CaptionTextColor = Color.Black,
                ClearTextColor = Color.Black,
                PromptTextColor = Color.White,
                StrokeColor = Color.Black,
                StrokeWidth = 2f,
                SignatureBackgroundColor = Color.White,
                SignatureLineColor = Color.Black,

                SaveText = "Save",
                CancelText = "Cancel",
                ClearText = "Clear",
                PromptText = "",
                CaptionText = "Please Sign Here"
            };
        }


        public abstract void Request(Action<SignatureResult> onResult);
        //public abstract void Load(IEnumerable<DrawPoint> points);
    }
}

