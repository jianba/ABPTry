const ENV = {
  dev: {
    apiUrl: 'http://localhost:44397',
    oAuthConfig: {
      issuer: 'http://localhost:44397',
      clientId: 'SzyBlog_App',
      clientSecret: '1q2w3e*',
      scope: 'SzyBlog',
    },
    localization: {
      defaultResourceName: 'SzyBlog',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44397',
    oAuthConfig: {
      issuer: 'http://localhost:44397',
      clientId: 'SzyBlog_App',
      clientSecret: '1q2w3e*',
      scope: 'SzyBlog',
    },
    localization: {
      defaultResourceName: 'SzyBlog',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
