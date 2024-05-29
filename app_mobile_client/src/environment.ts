export const environment = {
  production: import.meta.env.NODE_ENV === "production",
  apiUrl: import.meta.env.VITE_APP_API_URL || "http://localhost:8099",
  googleMapApiKey: import.meta.env.VITE_APP_GOOGLE_MAP_API_KEY || "AosX0AuioAGaTIuhCRfM2l05Bqh_emtlMTulvimcJC660V8JwOMg7ITZLaRhF3jn",
  googleMapApiMapId: import.meta.env.VITE_APP_GOOGLE_MAP_API_MAP_ID || "AosX0AuioAGaTIuhCRfM2l05Bqh_emtlMTulvimcJC660V8JwOMg7ITZLaRhF3jn",
  bingMapApiKey: import.meta.env.VITE_BING_MAPS_KEY || "AosX0AuioAGaTIuhCRfM2l05Bqh_emtlMTulvimcJC660V8JwOMg7ITZLaRhF3jn",
};
