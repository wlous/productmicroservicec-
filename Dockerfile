# We start from the official MySQL Docker image available: mysql
FROM mysql:latest

# Set the environment variable to provide a root password
ENV MYSQL_ROOT_PASSWORD=my-secret-pw

# Create Database
# RUN mkdir /usr/sql
# RUN chmod 644 /usr/sql

# And add our development setup script:
COPY Dump20180430.sql /docker-entrypoint-initdb.d

# RUN /etc/init.d/mysql start && \
# mysql -u root -p${MYSQL_ROOT_PASSWORD} -e "CREATE DATABASE productdb" && \
# mysql -u root -p${MYSQL_ROOT_PASSWORD} -D productdb < /usr/sql/Dump20180430.sql && \
# rm -rd /usr/sql && \