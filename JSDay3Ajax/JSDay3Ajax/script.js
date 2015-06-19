'use strict';
//var xhr = new XMLHttpRequest();

//xhr.addEventListener('load', function (e) {
//    var data = JSON.parse(xhr.responseText);
//    console.dir(data);
//});

//xhr.open('GET', '/products.json');
//xhr.send();

////-------------------------

//var request = new XMLHttpRequest();

//request.open('GET', '/products.json');

//request.onload = function () {
//    var data = JSON.parse(this.response);
//    console.dir(data);
//}

//request.send();
var callback = Symbol();

class Ajax {
    constructor(method, url, data) {
        this.method = method;
        this.url = url;
        this.data = data;
        this._callback = null;
        this._progress = null;
    }

    success(completedCallback, progressCallback) {
        this._callback = completedCallback;
        this._progress = progressCallback;
        this._doRequest();
    }

    _doRequest() {
        var that = this;
        var req = new XMLHttpRequest();
        req.open(this.method, this.url);
        req.onload = function () {
            var data = JSON.parse(this.response);
            if (typeof(that._callback) === "function") {
                that._callback(data);
            }
        }

        req.addEventListener('progress', function (e) {
            if (typeof(that._progress) === "function") {
                that._progress(e);
            }
        });

        if (this.method === 'GET') {
            req.send();
        }
        else {
            req.send(JSON.stringify(this.data));
        }
    }

    static get(url, callback) {
        var req = new XMLHttpRequest();
        req.open('GET', url);
        req.onload = function () {
            var data = JSON.parse(this.response);
            if (typeof(callback) === "function") {
                callback(data);
            }
        }
    }

    static post(url, data) {
        //TODO
    }
}

var myReq = new Ajax('GET', '/products.json');
myReq.success(function (data) {
    console.dir(data);
}, function (e) {
    if (e.lengthComputable) {
        var percentComplete = Math.round(e.loaded / e.total * 100);
        console.info(percentComplete + '% loaded.');
    } else {
        console.info('loading...');
    }
});

//Ajax.get('/products.json', function (data) {
//    console.dir(data);
//});