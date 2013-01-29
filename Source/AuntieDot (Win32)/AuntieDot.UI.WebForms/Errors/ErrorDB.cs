using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuntieDot.UI.Wen.Errors
{
    public class ErrorDB
    {
        public class ErrorStatusFormat
        {
            public int ErrorCode { get; set; }

            public string DevComment { get; set; }
            public string NorComment { get; set; }
        }
        #region DeclareErrorCodes
        public static IList<ErrorStatusFormat> ErrorLists = new List<ErrorStatusFormat>()
        {
            // Error 400
            new ErrorStatusFormat()
            {
                ErrorCode = 400,
                DevComment = "HTTP request failed! HTTP/1.1 400 Bad Request.",
                NorComment = "It's not what you said, it's how you said it"
            },

            // Error 401
            new ErrorStatusFormat()
            {
                ErrorCode = 401,
                DevComment = "HTTP request failed! HTTP/1.1 401 Unauthorized.",
                NorComment = "I didn't say you could put it there!"
            },

            // Error 403
            new ErrorStatusFormat()
            {
                ErrorCode = 403,
                DevComment = "HTTP request failed! HTTP/1.1 403 Forbidden.",
                NorComment = "Not tonight, I have a headache!"
            },

            // Error 404
            new ErrorStatusFormat()
            {
                ErrorCode = 404,
                DevComment = "HTTP request failed! HTTP/1.1 404 Not Found.",
                NorComment = "She's left you bro."
            },

            // Error 407
            new ErrorStatusFormat()
            {
                ErrorCode = 407,
                DevComment = "HTTP request failed! HTTP/1.1 407 Proxy Authentication Required.",
                NorComment = "Not without protection!"
            },

            // Error 408
            new ErrorStatusFormat()
            {
                ErrorCode = 408,
                DevComment = "HTTP request failed! HTTP/1.1 408 Request Timeout.",
                NorComment = "I want you to meet my mum!"
            },

            // Error 409
            new ErrorStatusFormat()
            {
                ErrorCode = 409,
                DevComment = "HTTP request failed! HTTP/1.1 409 Conflict.",
                NorComment = "I CAN'T BELIEVE YOU JUST SAID THAT!"
            },

            // Error 429
            new ErrorStatusFormat()
            {
                ErrorCode = 429,
                DevComment = "HTTP request failed! HTTP/1.1 429 Too Many Requests.",
                NorComment = "Stop asking me out!"
            },

            // Error 444
            new ErrorStatusFormat()
            {
                ErrorCode = 444,
                DevComment = "HTTP request failed! HTTP/1.1 444 No Response.",
                NorComment = "Does this make me look fat?"
            },

            // Error 451
            new ErrorStatusFormat()
            {
                ErrorCode = 451,
                DevComment = "HTTP request failed! HTTP/1.1 451 Unavailable For Legal Reasons.",
                NorComment = "She said she was 18! I swear!"
            },

            // Error 500
            new ErrorStatusFormat()
            {
                ErrorCode = 500,
                DevComment = "HTTP request failed! HTTP/1.1 500 Internal Server Error.",
                NorComment = "No sex, I'm on my period."
            },

            // Error 501
            new ErrorStatusFormat()
            {
                ErrorCode = 501,
                DevComment = "HTTP request failed! HTTP/1.1 501 Not Implemented.",
                NorComment = "Im not on birth control"
            },

            // Error 502
            new ErrorStatusFormat()
            {
                ErrorCode = 502,
                DevComment = "HTTP request failed! HTTP/1.1 502 Bad Gateway.",
                NorComment = "NO NO, WRONG HOLE!"
            },

            // Error 503
            new ErrorStatusFormat()
            {
                ErrorCode = 503,
                DevComment = "HTTP request failed! HTTP/1.1 503 Service Unavailable.",
                NorComment = "Lets be friends"
            },

            // Error 504
            new ErrorStatusFormat()
            {
                ErrorCode = 504,
                DevComment = "HTTP request failed! HTTP/1.1 504 Gateway Timeout.",
                NorComment = "I'm too sex for drunk tonight"
            },

            // Error 505
            new ErrorStatusFormat()
            {
                ErrorCode = 505,
                DevComment = "HTTP request failed! HTTP/1.1 505 HTTP Version Not Supported.",
                NorComment = "I think i'm a lesbian"
            },

            // Error 506
            new ErrorStatusFormat()
            {
                ErrorCode = 506,
                DevComment = "HTTP request failed! HTTP/1.1 506 HTTP Variant Also Negotiates.",
                NorComment = "I'm bi-sexual, do you have any cute female friends?"
            },

            // Error 507
            new ErrorStatusFormat()
            {
                ErrorCode = 507,
                DevComment = "HTTP request failed! HTTP/1.1 507 Insufficient Storage.",
                NorComment = "What do you mean my tits are too small?"
            },

            // Error 508
            new ErrorStatusFormat()
            {
                ErrorCode = 508,
                DevComment = "HTTP request failed! HTTP/1.1 508 Loop Detected.",
                NorComment = "It’s up to you. Swings and roundabouts baby."
            },

            // Error 509
            new ErrorStatusFormat()
            {
                ErrorCode = 509,
                DevComment = "HTTP request failed! HTTP/1.1 509 HTTP Bandwidth Limit Exceeded.",
                NorComment = "What? You want to do it AGAIN?"
            },

            // Error 510
            new ErrorStatusFormat()
            {
                ErrorCode = 510,
                DevComment = "HTTP request failed! HTTP/1.1 510 Not Extended.",
                NorComment = "Why is it not hard yet?"
            },

            // Error 511
            new ErrorStatusFormat()
            {
                ErrorCode = 511,
                DevComment = "HTTP request failed! HTTP/1.1 511 HTTP Network Authentication Required.",
                NorComment = "So, let me get this right, you want to go out with the lads?"
            }
        };
        #endregion

        public static ErrorStatusFormat GetFormatFromCode(int code)
        {
            foreach (ErrorStatusFormat format in ErrorLists)
                if (format.ErrorCode == code)
                    return format;
            return null;
        }
    }
}