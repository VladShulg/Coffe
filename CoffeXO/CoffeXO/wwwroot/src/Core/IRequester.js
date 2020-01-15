var Requester_Resx = /** @class */ (function () {
    function Requester_Resx() {
        this.YouPassedAnEmtpyArrayOfObjects = "Вы подали пустой объект в запрос";
        this.ErrorOccuredWeKnowAboutIt = "Произошла ошибка! Мы уже знаем о ней, и скоро с ней разберемся!";
        this.FilesNotSelected = "Файлы не выбраны";
    }
    return Requester_Resx;
}());
var Requester = /** @class */ (function () {
    function Requester() {
    }
    Requester.prototype.SendAjaxGet = function (link, data, onSuccessFunc, onErrorFunc) {
        var params = {
            type: "GET",
            data: data,
            url: link,
            async: true,
            cache: false,
            success: (function (response) {
                if (onSuccessFunc) {
                    onSuccessFunc(response);
                }
            }).bind(this),
            error: function (jqXHR, textStatus, errorThrown) {
                //Вызываю внешнюю функцию-обработчик
                if (onErrorFunc) {
                    onErrorFunc(jqXHR, textStatus, errorThrown);
                }
            }
        };
        $.ajax(params);
    };
    Requester.prototype.SendAjaxPost = function (link, data, onSuccessFunc, onErrorFunc) {
        if (data == null) {
            alert(Requester.Resources.YouPassedAnEmtpyArrayOfObjects);
            return;
        }
        var params = {};
        params.type = "POST";
        params.data = data;
        params.url = link;
        params.async = true;
        params.cache = false;
        params.success = function (response) {
            if (onSuccessFunc) {
                onSuccessFunc(response);
            }
        };
        params.error = function (jqXHR, textStatus, errorThrown) {
            //Вызываю внешнюю функцию-обработчик
            if (onErrorFunc) {
                onErrorFunc(jqXHR, textStatus, errorThrown);
            }
        };
        var isArray = data.constructor === Array;
        if (isArray) {
            params.contentType = "application/json; charset=utf-8";
            params.dataType = "json";
            params.data = JSON.stringify(data);
        }
        $.ajax(params);
    };
    Requester.Resources = new Requester_Resx();
    return Requester;
}());
var CoffeeAppCore = /** @class */ (function () {
    function CoffeeAppCore() {
    }
    CoffeeAppCore.Requester = new Requester();
    return CoffeeAppCore;
}());
