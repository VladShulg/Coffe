interface IRequester {
    SendAjaxGet(link: string, data: Object, onSuccessFunc: Function, onErrorFunc: Function): void;
    SendAjaxPost(link: string, data: Object, onSuccessFunc: Function, onErrorFunc: Function): void;
}

class Requester_Resx {
    YouPassedAnEmtpyArrayOfObjects: string = "Вы подали пустой объект в запрос";
    ErrorOccuredWeKnowAboutIt: string = "Произошла ошибка! Мы уже знаем о ней, и скоро с ней разберемся!";
    FilesNotSelected: string = "Файлы не выбраны";
}

class Requester implements IRequester {

    static Resources: Requester_Resx = new Requester_Resx();

   
    SendAjaxGet(link: string, data: Object, onSuccessFunc: Function, onErrorFunc: Function) {

        const params = {
            type: "GET",
            data: data,
            url: link,
            async: true,
            cache: false,
            success: (response => {
     
                if (onSuccessFunc) {
                    onSuccessFunc(response);
                }
            }).bind(this),

            error: (jqXHR, textStatus, errorThrown) => {
                //Вызываю внешнюю функцию-обработчик
                if (onErrorFunc) {
                    onErrorFunc(jqXHR, textStatus, errorThrown);
                }

            }
        };

        $.ajax(params);
    }

    SendAjaxPost(link: string, data: Object, onSuccessFunc: Function, onErrorFunc: Function) {

        if (data == null) {
            alert(Requester.Resources.YouPassedAnEmtpyArrayOfObjects);
            return;
        }


        let params: any = {};

        params.type = "POST";
        params.data = data;
        params.url = link;
        params.async = true;
        params.cache = false;
        params.success = response => {
            
            if (onSuccessFunc) {
                onSuccessFunc(response);
            }
        };

        params.error = (jqXHR, textStatus, errorThrown) => {
            
            //Вызываю внешнюю функцию-обработчик
            if (onErrorFunc) {
                onErrorFunc(jqXHR, textStatus, errorThrown);
            }

        };

        const isArray = data.constructor === Array;

        if (isArray) {
            params.contentType = "application/json; charset=utf-8";
            params.dataType = "json";
            params.data = JSON.stringify(data);
        }

        $.ajax(params);
    }
}

class CoffeeAppCore {
    static Requester: IRequester = new Requester();
}

