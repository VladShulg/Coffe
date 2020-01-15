interface IRequester {
    SendAjaxGet(link: string, data: Object, onSuccessFunc: Function, onErrorFunc: Function): void;
    SendAjaxPost(link: string, data: Object, onSuccessFunc: Function, onErrorFunc: Function): void;
}
declare class Requester_Resx {
    YouPassedAnEmtpyArrayOfObjects: string;
    ErrorOccuredWeKnowAboutIt: string;
    FilesNotSelected: string;
}
declare class Requester implements IRequester {
    static Resources: Requester_Resx;
    SendAjaxGet(link: string, data: Object, onSuccessFunc: Function, onErrorFunc: Function): void;
    SendAjaxPost(link: string, data: Object, onSuccessFunc: Function, onErrorFunc: Function): void;
}
declare class CoffeeAppCore {
    static Requester: IRequester;
}
