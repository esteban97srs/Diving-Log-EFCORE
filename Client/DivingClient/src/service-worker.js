importScripts('https://storage.googleapis.com/workbox-cdn/releases/6.0.2/workbox-sw.js');


//Routing que almacena en cache los datos de la base de datos
workbox.routing.registerRoute(
  new RegExp('https://localhost:5001/api/divings/'),
  new workbox.strategies.NetworkFirst
  ({
      cacheName: 'Api-Data',
    }),
);


//Routing que almacena la navegacion de la aplicacion.
workbox.routing.registerRoute(
    ({ request }) => request.mode === 'navigate',
    new workbox.strategies.NetworkFirst({
      cacheName: 'pages',
      plugins: [
        new workbox.cacheableResponse.CacheableResponsePlugin({
          statuses: [200],
        }),
      ],
    }),
  );

  //routing que almacena los recursos estaticos especificados en la ruta.
workbox.routing.registerRoute(
    /\.(?:js|css|scss)$/,
    new workbox.strategies.NetworkFirst({
      cacheName: "static-resources",
      plugins: [
        new workbox.expiration.ExpirationPlugin({
          maxEntries: 60,
          maxAgeSeconds: 20 * 24 * 60 * 60, // 20 Days
        }),
      ],
    })  
  );

//Routing encargado de almacenar imagenes que la aplicacion utilice
  workbox.routing.registerRoute(
    /\.(?:png|jpg|jpeg|svg|gif)$/,
    new workbox.strategies.NetworkFirst({
      cacheName: "Images",
      plugins: [
        new workbox.expiration.ExpirationPlugin({
          // Cache only 20 images.
          maxEntries: 20,
          // Cache for a maximum of a week.
          maxAgeSeconds: 7 * 24 * 60 * 60,
        }),
      ],
    })
  );
