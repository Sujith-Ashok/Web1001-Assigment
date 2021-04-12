const CACHE_NAME = 'Sujith web application cache';
//const CACHE_Secondary = 'Sujith web application cache second';
let urlsToCache = [
    '/'
];

self.addEventListener('install', function (event) {
    console.info('Service worker Installed');

    event.waitUntil(
        caches.open(CACHE_NAME)
            .then(function (cache) {
                console.log('Opened cache');
                return cache.addAll(urlsToCache);
            })
    );

    console.info('the page is being cached');
});


self.addEventListener('fetch', function (event) {
    event.respondWith(
        caches.match(event.request)
            .then(function (response) {
                
                if (response) {
                    return response;
                }

                //const newResponse = fetch(event.request);
                //caches.open(CACHE_Secondary).then((cache) => {
                //    cache.add(event.request);
                //});

                return fetch(event.request);
            }
            )
    );
});