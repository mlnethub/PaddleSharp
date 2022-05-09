﻿using System;

namespace Sdcb.PaddleOCR.KnownModels
{
    public class KnownOCRModel
    {
        private static readonly Uri[] ChineseKeyUris = new[]
        {
            new Uri(@"https://raw.githubusercontent.com/PaddlePaddle/PaddleOCR/release/2.3/ppocr/utils/ppocr_keys_v1.txt"), /* Github */
            new Uri(@"https://gitee.com/paddlepaddle/PaddleOCR/raw/release/2.3/ppocr/utils/ppocr_keys_v1.txt"), /* Gitee */
        };

        public static OCRModel PPOcrV2 = new OCRModel("ppocr-v2",
            new Uri(@"https://paddleocr.bj.bcebos.com/PP-OCRv2/chinese/ch_PP-OCRv2_det_infer.tar"),
            new Uri(@"https://paddleocr.bj.bcebos.com/dygraph_v2.0/ch/ch_ppocr_mobile_v2.0_cls_infer.tar"),
            new Uri(@"https://paddleocr.bj.bcebos.com/PP-OCRv2/chinese/ch_PP-OCRv2_rec_infer.tar"),
            ChineseKeyUris);

        // this model not correct.
        //public static OCRModel PPOcrMobileV2 = new OCRModel("ppocr-mobile-v2",
        //    new Uri(@"https://paddleocr.bj.bcebos.com/dygraph_v2.0/ch/ch_ppocr_mobile_v2.0_det_infer.tar"),
        //    new Uri(@"https://paddleocr.bj.bcebos.com/dygraph_v2.0/ch/ch_ppocr_mobile_v2.0_cls_infer.tar"),
        //    new Uri(@"https://paddleocr.bj.bcebos.com/dygraph_v2.0/ch/ch_ppocr_mobile_v2.0_rec_infer.tar"),
        //    ChineseKeyUris);

        public static OCRModel EnglishMobileV2 = new OCRModel("en-ppocr-mobile-v2",
            PPOcrV2.DetectionModelUris,
            PPOcrV2.ClassifierModelUris,
            new[] { new Uri(@"https://paddleocr.bj.bcebos.com/dygraph_v2.0/multilingual/en_number_mobile_v2.0_rec_infer.tar") },
            new[]
            {
                new Uri(@"https://raw.githubusercontent.com/PaddlePaddle/PaddleOCR/release/2.3/ppocr/utils/en_dict.txt"), /* Github */
                new Uri(@"https://gitee.com/paddlepaddle/PaddleOCR/raw/release/2.3/ppocr/utils/en_dict.txt"), /* Gitee */
            });

        public static OCRModel PPOcrServerV2 = new OCRModel("ppocr-server-v2",
            new Uri(@"https://paddleocr.bj.bcebos.com/dygraph_v2.0/ch/ch_ppocr_server_v2.0_det_infer.tar"),
            new Uri(@"https://paddleocr.bj.bcebos.com/dygraph_v2.0/ch/ch_ppocr_mobile_v2.0_cls_infer.tar"),
            new Uri(@"https://paddleocr.bj.bcebos.com/dygraph_v2.0/ch/ch_ppocr_server_v2.0_rec_infer.tar"),
            ChineseKeyUris);

        public static OCRModel ChineseTranditionalMobileV2 = new OCRModel("chinese-cht-mobile-v2",
            PPOcrV2.DetectionModelUris,
            PPOcrV2.ClassifierModelUris,
            new[] { new Uri(@"https://paddleocr.bj.bcebos.com/dygraph_v2.0/multilingual/chinese_cht_mobile_v2.0_rec_infer.tar") },
            new[]
            {
                new Uri(@"https://raw.githubusercontent.com/PaddlePaddle/PaddleOCR/release/2.4/ppocr/utils/dict/chinese_cht_dict.txt"), /* Github */
                new Uri(@"https://gitee.com/paddlepaddle/PaddleOCR/raw/release/2.4/ppocr/utils/dict/chinese_cht_dict.txt"), /* Gitee */
            });

        // 法文
        public static OCRModel FrenchMobileV2 = new OCRModel("fr-mobile-v2",
            PPOcrV2.DetectionModelUris,
            PPOcrV2.ClassifierModelUris,
            new[] { new Uri(@"https://paddleocr.bj.bcebos.com/dygraph_v2.0/multilingual/french_mobile_v2.0_rec_infer.tar") },
            new[]
            {
                new Uri(@"https://raw.githubusercontent.com/PaddlePaddle/PaddleOCR/release/2.4/ppocr/utils/dict/french_dict.txt"), /* Github */
                new Uri(@"https://gitee.com/paddlepaddle/PaddleOCR/raw/release/2.4/ppocr/utils/dict/french_dict.txt"), /* Gitee */
            });

        // 德文
        public static OCRModel GermanMobileV2 = new OCRModel("ge-mobile-v2",
            PPOcrV2.DetectionModelUris,
            PPOcrV2.ClassifierModelUris,
            new[] { new Uri(@"https://paddleocr.bj.bcebos.com/dygraph_v2.0/multilingual/german_mobile_v2.0_rec_infer.tar") },
            new[]
            {
                new Uri(@"https://raw.githubusercontent.com/PaddlePaddle/PaddleOCR/release/2.4/ppocr/utils/dict/german_dict.txt"), /* Github */
                new Uri(@"https://gitee.com/paddlepaddle/PaddleOCR/raw/release/2.4/ppocr/utils/dict/grench_dict.txt"), /* Gitee */
            });

        // 韩文
        public static OCRModel KoreanMobileV2 = new OCRModel("ko-mobile-v2",
            PPOcrV2.DetectionModelUris,
            PPOcrV2.ClassifierModelUris,
            new[] { new Uri(@"https://paddleocr.bj.bcebos.com/dygraph_v2.0/multilingual/korean_mobile_v2.0_rec_infer.tar") },
            new[]
            {
                new Uri(@"https://raw.githubusercontent.com/PaddlePaddle/PaddleOCR/release/2.4/ppocr/utils/dict/korean_dict.txt"), /* Github */
                new Uri(@"https://gitee.com/paddlepaddle/PaddleOCR/raw/release/2.4/ppocr/utils/dict/korean_dict.txt"), /* Gitee */
            });

        // 日文
        public static OCRModel JapaneseMobileV2 = new OCRModel("jap-mobile-v2",
            PPOcrV2.DetectionModelUris,
            PPOcrV2.ClassifierModelUris,
            new[] { new Uri(@"https://paddleocr.bj.bcebos.com/dygraph_v2.0/multilingual/japan_mobile_v2.0_rec_infer.tar") },
            new[]
            {
                new Uri(@"https://raw.githubusercontent.com/PaddlePaddle/PaddleOCR/release/2.4/ppocr/utils/dict/japan_dict.txt"), /* Github */
                new Uri(@"https://gitee.com/paddlepaddle/PaddleOCR/raw/release/2.4/ppocr/utils/dict/japan_dict.txt"), /* Gitee */
            });

        //泰卢固文
        public static OCRModel TeluguMobileV2 = new OCRModel("te-mobile-v2",
            PPOcrV2.DetectionModelUris,
            PPOcrV2.ClassifierModelUris,
            new[] { new Uri(@"https://paddleocr.bj.bcebos.com/dygraph_v2.0/multilingual/te_mobile_v2.0_rec_infer.tar") },
            new[]
            {
                new Uri(@"https://raw.githubusercontent.com/PaddlePaddle/PaddleOCR/release/2.4/ppocr/utils/dict/te_dict.txt"), /* Github */
                new Uri(@"https://gitee.com/paddlepaddle/PaddleOCR/raw/release/2.4/ppocr/utils/dict/te_dict.txt"), /* Gitee */
            });

        //卡纳达文
        public static OCRModel KannadaMobileV2 = new OCRModel("ka-mobile-v2",
            PPOcrV2.DetectionModelUris,
            PPOcrV2.ClassifierModelUris,
            new[] { new Uri(@"https://paddleocr.bj.bcebos.com/dygraph_v2.0/multilingual/ka_mobile_v2.0_rec_infer.tar") },
            new[]
            {
                new Uri(@"https://raw.githubusercontent.com/PaddlePaddle/PaddleOCR/release/2.4/ppocr/utils/dict/ka_dict.txt"), /* Github */
                new Uri(@"https://gitee.com/paddlepaddle/PaddleOCR/raw/release/2.4/ppocr/utils/dict/ka_dict.txt"), /* Gitee */
            });

        //泰米尔文
        public static OCRModel TamilMobileV2 = new OCRModel("ta-mobile-v2",
            PPOcrV2.DetectionModelUris,
            PPOcrV2.ClassifierModelUris,
            new[] { new Uri(@"https://paddleocr.bj.bcebos.com/dygraph_v2.0/multilingual/ta_mobile_v2.0_rec_infer.tar") },
            new[]
            {
                new Uri(@"https://raw.githubusercontent.com/PaddlePaddle/PaddleOCR/release/2.4/ppocr/utils/dict/ta_dict.txt"), /* Github */
                new Uri(@"https://gitee.com/paddlepaddle/PaddleOCR/raw/release/2.4/ppocr/utils/dict/ta_dict.txt"), /* Gitee */
            });

        //拉丁文
        public static OCRModel LatinMobileV2 = new OCRModel("latin-mobile-v2",
            PPOcrV2.DetectionModelUris,
            PPOcrV2.ClassifierModelUris,
            new[] { new Uri(@"https://paddleocr.bj.bcebos.com/dygraph_v2.0/multilingual/latin_mobile_v2.0_rec_infer.tar") },
            new[]
            {
                new Uri(@"https://raw.githubusercontent.com/PaddlePaddle/PaddleOCR/release/2.4/ppocr/utils/dict/latin_dict.txt"), /* Github */
                new Uri(@"https://gitee.com/paddlepaddle/PaddleOCR/raw/release/2.4/ppocr/utils/dict/latin_dict.txt"), /* Gitee */
            });

        //阿拉伯字母
        public static OCRModel ArabicMobileV2 = new OCRModel("arabic-mobile-v2",
            PPOcrV2.DetectionModelUris,
            PPOcrV2.ClassifierModelUris,
            new[] { new Uri(@"https://paddleocr.bj.bcebos.com/dygraph_v2.0/multilingual/arabic_mobile_v2.0_rec_infer.tar") },
            new[]
            {
                new Uri(@"https://raw.githubusercontent.com/PaddlePaddle/PaddleOCR/release/2.4/ppocr/utils/dict/arabic_dict.txt"), /* Github */
                new Uri(@"https://gitee.com/paddlepaddle/PaddleOCR/raw/release/2.4/ppocr/utils/dict/arabic_dict.txt"), /* Gitee */
            });

        //斯拉夫字母
        public static OCRModel CyrillicMobileV2 = new OCRModel("cyrillic-mobile-v2",
            PPOcrV2.DetectionModelUris,
            PPOcrV2.ClassifierModelUris,
            new[] { new Uri(@"https://paddleocr.bj.bcebos.com/dygraph_v2.0/multilingual/cyrillic_mobile_v2.0_rec_infer.tar") },
            new[]
            {
                new Uri(@"https://raw.githubusercontent.com/PaddlePaddle/PaddleOCR/release/2.4/ppocr/utils/dict/cyrillic_dict.txt"), /* Github */
                new Uri(@"https://gitee.com/paddlepaddle/PaddleOCR/raw/release/2.4/ppocr/utils/dict/cyrillic_dict.txt"), /* Gitee */
            });

        //梵文字母
        public static OCRModel DevanagariMobileV2 = new OCRModel("devanagari-mobile-v2",
            PPOcrV2.DetectionModelUris,
            PPOcrV2.ClassifierModelUris,
            new[] { new Uri(@"https://paddleocr.bj.bcebos.com/dygraph_v2.0/multilingual/devanagari_mobile_v2.0_rec_infer.tar") },
            new[]
            {
                new Uri(@"https://raw.githubusercontent.com/PaddlePaddle/PaddleOCR/release/2.4/ppocr/utils/dict/devanagari_dict.txt"), /* Github */
                new Uri(@"https://gitee.com/paddlepaddle/PaddleOCR/raw/release/2.4/ppocr/utils/dict/devanagari_dict.txt"), /* Gitee */
            });
    }
}
